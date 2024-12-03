using CardapioDigital.Infra.Data.CardapioDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CardapioDigital.Infra.IoC
{
    internal static class Db
    {
        public static IServiceCollection AddInfraestructureDb(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<CardapioDbContext>(options => options
                    .UseSqlServer(config.GetConnectionString("Dev"), x => x
                   .MigrationsAssembly(typeof(CardapioDbContext).Assembly.FullName)));


            return services;
        }
    }
}
