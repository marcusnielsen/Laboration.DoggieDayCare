using System.Web.Http;

namespace Laboration.DoggieDayCare.WebService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            UnityConfig.RegisterComponents(); 
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
