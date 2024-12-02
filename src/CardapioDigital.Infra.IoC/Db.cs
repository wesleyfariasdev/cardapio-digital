using CardapioDigital.Infra.Data.CardapioDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardapioDigital.Infra.IoC
{
    internal static class Db
    {
        public static IServiceCollection AddInfraestructureDb(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<CardapioDbContext>(options => options
                    .UseSqlServer(config.GetConnectionString(@"Server=(localdb)\\mssqllocaldb;Database=LOLProfile;Trusted_Connection=True;
                       MultipleActiveResultSets=true"), x => x
                   .MigrationsAssembly(typeof(CardapioDbContext).Assembly.FullName)));


            return services;
        }
    }
}
