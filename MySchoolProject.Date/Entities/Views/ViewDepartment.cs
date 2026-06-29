using Microsoft.EntityFrameworkCore;
using MySchoolProject.Date.Commons;

namespace MySchoolProject.Date.Entities.Views
{
    [Keyless]
    public class ViewDepartment : GeneralLocalizableEntity
    {
        public int DId { get; set; }
        public string? DNameAr { get; set; }
        public string? DNameEn { get; set; }
        public int StudentCount { get; set; }
    }
}