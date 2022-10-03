using Abp.Application.Services.Dto;

namespace GenshinImpactGuider.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

