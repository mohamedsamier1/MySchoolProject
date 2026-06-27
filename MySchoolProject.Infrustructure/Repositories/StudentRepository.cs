using Microsoft.EntityFrameworkCore;
using MySchoolProject.Date.Entities;
using MySchoolProject.Infrustructure.Data;
using MySchoolProject.Infrustructure.InfrustructureBases;
using MySchoolProject.Infrustructure.IRepositories;

namespace MySchoolProject.Infrustructure.Repositories
{
    public class StudentRepository : GenericRepositoryAsync<Student>, IStudentRepository
    {
        #region Fields
        private readonly DbSet<Student> _dbStudent;

        #endregion

        #region Constructors
        public StudentRepository(ApplicationDbContext contxt) : base(contxt)
        {
            _dbStudent = contxt.Set<Student>();
        }
        #endregion


        #region Handles Functions
        public async Task<List<Student>> GeStudentsListAsunc()
        {
            return await _dbStudent.Include(n => n.Department).ToListAsync();
        }
        #endregion

    }
}
