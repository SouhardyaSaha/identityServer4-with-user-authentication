using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.IdentityModel.Tokens;

namespace IdentityServer.Demo.Api_.Extensions;

public static class ApplicationServicesExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        const string identityServiceUrl = "https://localhost:5001";

        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.Authority = "https://localhost:5001";
                options.Audience = "identity-server-demo-api";
                // options.TokenValidationParameters = new TokenValidationParameters
                // {
                //     ValidateAudience = false
                // };
            });
        
        services.AddCors(o => o.AddPolicy("CorsPolicy", policy =>
        {
            policy
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials()
                .WithOrigins("http://localhost:3000");
        }));

        return services;
    }
}