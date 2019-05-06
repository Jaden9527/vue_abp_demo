using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using vue_abp_demo.Authorization.Roles;
using vue_abp_demo.Authorization.Users;
using vue_abp_demo.MultiTenancy;

namespace vue_abp_demo.EntityFrameworkCore
{
    public class vue_abp_demoDbContext : AbpZeroDbContext<Tenant, Role, User, vue_abp_demoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public vue_abp_demoDbContext(DbContextOptions<vue_abp_demoDbContext> options)
            : base(options)
        {
        }
    }
}
