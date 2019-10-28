using Store_Domain.Repository;
using Store_Domain.Service;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Store_UI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IStoreService, StoreService>();
            container.RegisterType<IStoreRepository, StoreRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}