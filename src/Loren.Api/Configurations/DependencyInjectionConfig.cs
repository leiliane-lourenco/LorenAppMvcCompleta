using Loren.Api.Extensions;
using Loren.Business.Interfaces;
using Loren.Business.Notifications;
using Loren.Business.Services;
using Loren.Data.Context;
using Loren.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace Loren.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services )
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IFornecedorService, FornecedorService>();


            return services;
        }
    }


}
