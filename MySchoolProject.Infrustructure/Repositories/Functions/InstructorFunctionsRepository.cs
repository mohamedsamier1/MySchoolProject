using MySchoolProject.Infrustructure.IRepositories.Functions;
using System.Data.Common;

namespace MySchoolProject.Infrustructure.Repositories.Functions
{
    public class InstructorFunctionsRepository : IInstructorFunctionsRepository
    {
        #region MyRegion

        #endregion

        #region MyRegion
        public InstructorFunctionsRepository()
        {

        }
        #endregion

        #region MyRegion
        public decimal GetSummationSalaryofInstructor(string query, DbCommand dbCommand)
        {
            decimal response = 0;
            dbCommand.CommandText = query;
            var value = dbCommand.ExecuteScalar();
            var result = value.ToString();
            if (decimal.TryParse(result, out decimal d))
            {
                response = d;
            }
            return response;
        }
        #endregion

    }
}
