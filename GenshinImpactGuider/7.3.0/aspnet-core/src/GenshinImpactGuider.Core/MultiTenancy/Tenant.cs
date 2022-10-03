using Abp.MultiTenancy;
using GenshinImpactGuider.Authorization.Users;

namespace GenshinImpactGuider.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
