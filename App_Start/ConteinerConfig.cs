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

            builder.RegisterType<SqlMessageData>().As<IMessageData>().SingleInstance();
            builder.RegisterType<SqlUserData>().As<IUserData>().SingleInstance();
            builder.RegisterType<SqlTypeData>().As<ITypeData>().SingleInstance();
            builder.RegisterType<SqlProductData>().As<IProductData>().SingleInstance();
            builder.RegisterType<SqlAuthorData>().As<IAuthorData>().SingleInstance();

            builder.RegisterType<UserDbContext>().SingleInstance();
            builder.RegisterType<MessageDbContext>().SingleInstance();
            builder.RegisterType<StoreDbContext>().SingleInstance();

            IContainer container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}