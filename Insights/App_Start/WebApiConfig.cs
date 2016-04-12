using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Web.Http.Dependencies;
using Ninject;
using Ninject.Syntax;
using Ninject.Activation;
using Ninject.Parameters;

using Ninject.Web.Common;
using Ninject.Extensions.Conventions;
using Insights.App_Start;

namespace Insights
{
    #region Dependency Resolver
    internal class NinjectDependencyResolver : NinjectScope, IDependencyResolver
    {
        private readonly IKernel kernel;

        public NinjectDependencyResolver(IKernel kernel)
            : base(kernel)
        {
            if (kernel == null)
                throw new ArgumentNullException("kernel");

            this.kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectScope(this.kernel.BeginBlock());
        }
    }

    internal class NinjectScope : IDependencyScope
    {
        protected IResolutionRoot resolutionRoot;
        public NinjectScope(IResolutionRoot kernel)
        {
            resolutionRoot = kernel;
        }
        public object GetService(Type serviceType)
        {
            IRequest request = resolutionRoot.CreateRequest(serviceType, null, new Parameter[0], true, true);
            return resolutionRoot.Resolve(request).SingleOrDefault();
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            IRequest request = resolutionRoot.CreateRequest(serviceType, null, new Parameter[0], true, true);
            return resolutionRoot.Resolve(request).ToList();
        }
        public void Dispose()
        {
            IDisposable disposable = (IDisposable)resolutionRoot;
            if (disposable != null) disposable.Dispose();
            resolutionRoot = null;
        }
    }
    #endregion

    public static class WebApiConfig
    {
        public static HttpConfiguration Register()
        {
            // Web API configuration and services
            var config = new HttpConfiguration();
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.DependencyResolver = new NinjectDependencyResolver(NinjectWebCommon.CreateKernel());
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.EnableCors(new EnableCorsAttribute("http://localhost:61565/, http://localhost:37045, http://localhost:37046", "accept, authorization", "GET", "WWW-Authenticate"));
            

        

            config.DependencyResolver = new NinjectDependencyResolver(NinjectWebCommon.CreateKernel());
            config.Routes.MapHttpRoute(
                  name: "DefaultApi",
                  routeTemplate: "api/{controller}/{id}",
                  defaults: new { id = RouteParameter.Optional }
              );

            return config;
        }


        //public static void Register(HttpConfiguration config)
        //{ // Web API configuration and services

        //    config.DependencyResolver = new NinjectDependencyResolver(NinjectWebCommon.CreateKernel());
        //    // Web API configuration and services
        //    // Configure Web API to use only bearer token authentication.
        //    config.Formatters.Remove(config.Formatters.XmlFormatter);

        //        // Web API routes

        //        config.EnableCors(new EnableCorsAttribute("http://localhost:61565/, http://localhost:37045, http://localhost:37046", "accept, authorization", "GET", "WWW-Authenticate"));


        //    // Web API routes
        //    config.MapHttpAttributeRoutes();

        //    config.Routes.MapHttpRoute(
        //        name: "DefaultApi",
        //        routeTemplate: "api/{controller}/{id}",
        //        defaults: new { id = RouteParameter.Optional }
        //    );
        //}
    }
}
