using Autofac;
using Autofac.Integration.Mvc;
using DahaimMVC.Areas.Admin.Models;
using DahaimMVC.Areas.Shop.Models;
using DahaimMVC.Models;
using System.Web.Mvc;

namespace DahaimMVC
{
    public static class ConteinerConfig
    {
        internal static void RegisterConfig()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<SqlMessageData>().As<IMessageData>().InstancePerRequest();
            builder.RegisterType<SqlUserData>().As<IUserData>().InstancePerRequest();
            builder.RegisterType<SqlTypeData>().As<ITypeData>().InstancePerRequest();
            builder.RegisterType<SqlProductData>().As<IProductData>().InstancePerRequest();
            builder.RegisterType<SqlAuthorData>().As<IAuthorData>().InstancePerRequest();

            builder.RegisterType<UserDbContext>().InstancePerRequest();
            builder.RegisterType<MessageDbContext>().InstancePerRequest();
            builder.RegisterType<StoreDbContext>().InstancePerRequest();

            IContainer container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}