using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Cors;
using System.Web.Cors;
using System.Threading.Tasks;
using System.IdentityModel.Tokens;
using IdentityServer3.AccessTokenValidation;

[assembly: OwinStartup(typeof(CorsApi.Startup))]

namespace CorsApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            JwtSecurityTokenHandler.InboundClaimTypeMap.Clear();

            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions
            {
                Authority = "https://localhost:44333/core",
                RequiredScopes = new[] { "write" }
            });

            app.UseWebApi(Insights.WebApiConfig.Register());
        }
    }
}
