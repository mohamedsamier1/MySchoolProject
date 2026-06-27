using MediatR;
using MySchoolProject.Core.Bases;
using MySchoolProject.Date.DTOS;

namespace MySchoolProject.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserClaimsQuery : IRequest<Response<ManagUserClaimsDto>>
    {
        public int UserId { get; set; }
    }
}
