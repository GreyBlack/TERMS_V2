using Autofac;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using TERMS_V2.Web.Controllers;
using TERMS_V2.Application;
using TERMS_V2.Domain.Service;
using TERMS_V2.Repository;
using System.Linq;

namespace TERMS_V2.Web
{
    public class AutofacModuleRegister : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<UserInfoRepository>().As<IUserInfoRepository>();

            // Web层
            var controllersTypesInAssembly = typeof(Startup).Assembly.GetExportedTypes().Where(type => typeof(ControllerBase).IsAssignableFrom(type)).ToArray();
            builder.RegisterTypes(controllersTypesInAssembly).PropertiesAutowired();
            // App层
            builder.RegisterAssemblyTypes(typeof(UserAppService).Assembly).PropertiesAutowired();
            // Doamin层
            builder.RegisterAssemblyTypes(typeof(UserService).Assembly).PropertiesAutowired();
            // Repository层
            builder.RegisterAssemblyTypes(typeof(BdUiUserRepository).Assembly).AsImplementedInterfaces().PropertiesAutowired();
        }
    }
}