using MediatR;
using MySchoolProject.Core.Bases;
using MySchoolProject.Date.DTOS;

namespace MySchoolProject.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserRolesQuery : IRequest<Response<ManageUserRolesDto>>
    {
        public int UserId { get; set; }

        public ManageUserRolesQuery(int userId)
        {
            UserId = userId;
        }
    }
}
