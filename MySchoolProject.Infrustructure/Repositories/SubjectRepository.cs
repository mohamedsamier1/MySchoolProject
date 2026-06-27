using Microsoft.EntityFrameworkCore;
using MySchoolProject.Date.Entities;
using MySchoolProject.Infrustructure.Data;
using MySchoolProject.Infrustructure.InfrustructureBases;
using MySchoolProject.Infrustructure.IRepositories;

namespace MySchoolProject.Infrustructure.Repositories
{
    public class SubjectRepository : GenericRepositoryAsync<Subject>, ISubjectRepository
    {
        #region Fields
        private readonly DbSet<Subject> _dbSubject;

        #endregion

        #region Constructors
        public SubjectRepository(ApplicationDbContext contxt) : base(contxt)
        {
            _dbSubject = contxt.Set<Subject>();
        }
        #endregion
        #region Handelfuntions

        #endregion
    }
}
