using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using vue_abp_demo.Authorization.Users;
using vue_abp_demo.Editions;

namespace vue_abp_demo.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
