[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ShoppingStore.Web.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ShoppingStore.Web.NinjectWebCommon), "Stop")]


namespace ShoppingStore.Web
{
    using System;
    using System.Web;
    using System.Web.Mvc;

    using Ninject;
    using Ninject.Web.Common;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            //Creates the kernel
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
            //Register service for DependencyResolver
            ResiterServices(kernel);
            return kernel;
        }

        private static void ResiterServices(IKernel kernel)
        {
            DependencyResolver.SetResolver(new Infrastructure.NinjectDependencyResolver(kernel));
        }
    }
}