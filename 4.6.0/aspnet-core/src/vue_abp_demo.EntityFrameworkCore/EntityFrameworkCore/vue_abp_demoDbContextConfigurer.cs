using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace vue_abp_demo.EntityFrameworkCore
{
    public static class vue_abp_demoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<vue_abp_demoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<vue_abp_demoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
