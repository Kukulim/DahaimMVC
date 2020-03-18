using Autofac;
using Autofac.Integration.Mvc;
using DahaimMVC.Areas.Admin.Models;
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

            builder.RegisterType<UserDbContext>().SingleInstance();
            builder.RegisterType<MessageDbContext>().SingleInstance();           

            IContainer container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}