using Autofac;
using NLayer.Core.Repository;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Repository;
using NLayer.Repository.Repositories;
using NLayer.Repository.UnitOfWorks;
using NLayer.Service.Mapping;
using NLayer.Service.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace NLayer.API.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();


            // projeler içerisinde dahil olan classları verebiliyoruz
            // api kısmında ise bulunduğu assembly çek diyoruz sadece
            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssambly = Assembly.GetAssembly(typeof(MapProfile));



            // sonu repository ile bitiyor çoğunun sonu repository ile bitenlerden yakalayabiliriz.
            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssambly)
                .Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
            // InstancePerLifetimeScope => AddScoped() or AddScoped<T>()
            // .InstancePerDependency() => AddTransient()
            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssambly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}