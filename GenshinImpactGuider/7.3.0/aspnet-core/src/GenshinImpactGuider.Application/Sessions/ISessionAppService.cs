using System.Threading.Tasks;
using Abp.Application.Services;
using GenshinImpactGuider.Sessions.Dto;

namespace GenshinImpactGuider.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
