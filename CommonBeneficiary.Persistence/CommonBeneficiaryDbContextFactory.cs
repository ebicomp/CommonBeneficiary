using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CommonBeneficiary.Persistence
{
    public class CommonBeneficiaryDbContextFactory : IDesignTimeDbContextFactory<CommonBeneficiaryDbContext>
    {
        public CommonBeneficiaryDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var builder = new DbContextOptionsBuilder<CommonBeneficiaryDbContext>();
            var connectionString = configuration.GetConnectionString("CommonBeneficiaryConnectionString");

            builder.UseSqlServer(connectionString);

            return new CommonBeneficiaryDbContext(builder.Options);
        }
    }

}

