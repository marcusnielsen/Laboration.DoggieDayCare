using System.Web.Http;
using Laboration.DoggieDayCare.WebService.Models;
using Microsoft.Practices.Unity;
using Unity.WebApi;

namespace Laboration.DoggieDayCare.WebService
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<DoggieDayCareContext, DoggieDayCareContext>();
            container.RegisterType<IBookingRepository, BookingRepository>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}