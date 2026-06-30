using Microsoft.AspNetCore.Http;
using MySchoolProject.Date.Entities;

namespace MySchoolProject.Service.Abstracts
{
    public interface IInstructorService
    {
        public Task<decimal> GetSummationSalaryofInstructor();
        public Task<string> AddInstructorAsync(Instructor instructor, IFormFile formFile);
    }
}
