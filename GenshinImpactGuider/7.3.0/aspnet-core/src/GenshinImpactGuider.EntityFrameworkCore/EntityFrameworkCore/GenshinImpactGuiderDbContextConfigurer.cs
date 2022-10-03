using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GenshinImpactGuider.EntityFrameworkCore
{
    public static class GenshinImpactGuiderDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GenshinImpactGuiderDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GenshinImpactGuiderDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
