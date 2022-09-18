using CommonBeneficiary.Application.Contracts.Persistance;
using CommonBeneficiary.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CommonBeneficiary.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CommonBeneficiaryDbContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("CommonBeneficiaryConnectionString"));
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IRelationTypeRepository, RelationTypeRepository>();
            return services;
        }
    }
}
