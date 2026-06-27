
using MySchoolProject.Date.Entities;
using MySchoolProject.Date.Helpers;

namespace MySchoolProject.Service.Abstracts
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentListAsync();

        public Task<Student> GetStudentByIdAsync(int id);
        public Task<string> CreatNewStudentAsync(Student student);
        public Task<string> EditStudentAsync(Student student);
        public Task<string> DeletStudentAsyAsync(Student student);
        public IQueryable<Student> GetStudentQuerable();
        public IQueryable<Student> GetStudentByDepartmentIdQuerable(int Did);
        public IQueryable<Student> FilterStuedntPaginatedQuerable(StudentOrderingEnum orderingEnum, string search);

    }
}
