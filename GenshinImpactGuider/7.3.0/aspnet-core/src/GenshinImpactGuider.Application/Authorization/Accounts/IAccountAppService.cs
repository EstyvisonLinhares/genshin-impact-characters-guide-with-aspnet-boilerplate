using System.Threading.Tasks;
using Abp.Application.Services;
using GenshinImpactGuider.Authorization.Accounts.Dto;

namespace GenshinImpactGuider.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
