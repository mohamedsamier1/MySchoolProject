using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MySchoolProject.Date.Entities;
using MySchoolProject.Infrustructure.Data;
using MySchoolProject.Infrustructure.IRepositories;
using MySchoolProject.Infrustructure.IRepositories.Functions;
using MySchoolProject.Service.Abstracts;

namespace MySchoolProject.Service.Implementations
{
    public class InstructorService : IInstructorService
    {
        #region Faild
        private readonly ApplicationDbContext _context;
        private readonly IInstructorFunctionsRepository _instructorFunctionsRepository;
        private readonly IFileService _fileService;
        private readonly IInstructorsRepository _instructorsRepository;
        private readonly IHttpContextAccessor _contextAccessor;
        #endregion
        #region Const
        public InstructorService(ApplicationDbContext context, IInstructorFunctionsRepository instructorFunctionsRepository, IFileService fileService, IInstructorsRepository instructorsRepository, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _instructorFunctionsRepository = instructorFunctionsRepository;
            _fileService = fileService;
            _instructorsRepository = instructorsRepository;
            _contextAccessor = contextAccessor;
        }
        #endregion
        #region Handelfunction
        public Task<decimal> GetSummationSalaryofInstructor()
        {
            decimal resutl = 0;
            using (var cmd = _context.Database.GetDbConnection().CreateCommand())
            {
                if (cmd.Connection.State != System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                resutl = _instructorFunctionsRepository.GetSummationSalaryofInstructor("select dbo.GetSalarySummation()", cmd);

            }
            return Task.FromResult(resutl);
        }

        public async Task<string> AddInstructorAsync(Instructor instructor, IFormFile formFile)
        {
            var context = _contextAccessor.HttpContext.Request;
            var basUrl = context.Scheme + "://" + context.Host;
            var imageUrl = await _fileService.UploadImage("Instructors", formFile);
            switch (imageUrl)
            {
                case "NoImage": return "NoImage";
                case "FailedToUploudImage": return "FailedToUploudImage";

            }
            instructor.Image = basUrl + imageUrl;
            try
            {
                await _instructorsRepository.AddAsync(instructor);
                return "Success";
            }
            catch (Exception)
            {

                return "FailedInAdd";
            }


        }


        #endregion

    }
}
