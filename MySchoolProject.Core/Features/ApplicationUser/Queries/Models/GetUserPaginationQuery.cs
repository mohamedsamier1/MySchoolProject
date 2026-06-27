using MediatR;
using MySchoolProject.Core.Features.ApplicationUser.Queries.Response;
using MySchoolProject.Core.Wrappers;

namespace MySchoolProject.Core.Features.ApplicationUser.Queries.Models
{
    public class GetUserPaginationQuery : IRequest<PaginatedResult<GetUserListResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
