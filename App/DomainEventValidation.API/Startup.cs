using System.Web.Http;
using DomainEventValidation.API.Helpers;
using DomainEventValidation.Domain.DomainEvents;
using DomainEventValidation.Infra.CrossCutting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

namespace DomainEventValidation.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            ConfigureDependecyInjection(app, config);
            ConfigureWebApi(config);

            app.UseWebApi(config);
        }

        public static void ConfigureWebApi(HttpConfiguration config)
        {
            var formatters = config.Formatters;
            formatters.Remove(formatters.XmlFormatter);

            var jsonSettings = formatters.JsonFormatter.SerializerSettings;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        public static void ConfigureDependecyInjection(IAppBuilder app, HttpConfiguration config)
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            SimpleInjectorContainer.DependencyResolver(container);
            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
            DomainEvent.Container = new DomainEventsContainer(container);
        }
    }
}