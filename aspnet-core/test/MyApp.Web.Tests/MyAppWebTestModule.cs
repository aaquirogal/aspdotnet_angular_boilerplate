using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyApp.EntityFrameworkCore;
using MyApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyApp.Web.Tests
{
    [DependsOn(
        typeof(MyAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyAppWebTestModule : AbpModule
    {
        public MyAppWebTestModule(MyAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyAppWebMvcModule).Assembly);
        }
    }
}