using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using vue_abp_demo.Configuration;
using vue_abp_demo.Web;

namespace vue_abp_demo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class vue_abp_demoDbContextFactory : IDesignTimeDbContextFactory<vue_abp_demoDbContext>
    {
        public vue_abp_demoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<vue_abp_demoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            vue_abp_demoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(vue_abp_demoConsts.ConnectionStringName));

            return new vue_abp_demoDbContext(builder.Options);
        }
    }
}
