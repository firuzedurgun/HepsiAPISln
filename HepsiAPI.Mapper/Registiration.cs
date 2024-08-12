using HepsiAPI.Application.Interfaces.AutoMapper;
using Microsoft.Extensions.DependencyInjection;


namespace HepsiAPI.Mapper
{
    public static class Registiration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }
    }
}
