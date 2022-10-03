using Abp.Application.Services;
using GenshinImpactGuider.MultiTenancy.Dto;

namespace GenshinImpactGuider.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

