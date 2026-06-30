using System.Data.Common;

namespace MySchoolProject.Infrustructure.IRepositories.Functions
{
    public interface IInstructorFunctionsRepository
    {
        public decimal GetSummationSalaryofInstructor(string query, DbCommand dbCommand);
    }
}
