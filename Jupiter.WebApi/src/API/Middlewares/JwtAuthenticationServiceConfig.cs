﻿
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Jupiter.Business.Models;
using Jupiter.Data.DataAccess.Helper;

namespace Jupiter.WebApi.Middlewares
{
    public static class JwtAuthenticationServiceConfig
    {
        public static void AddJwtAuthenticationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Register the ConfigurationBuilder instance of AuthSettings
            var authSettings = configuration.GetSection("jwt");
            services.Configure<JwtOptions>(authSettings);

            var appSettings = authSettings.Get<JwtOptions>();

            var key = Encoding.ASCII.GetBytes(appSettings.secretKey);

            var signingKey = new SymmetricSecurityKey(key);

            var tokenValidationParams = new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,

                ValidIssuer = configuration["jwt:issuer"].ToString(),
                ValidateIssuer = false,
                ValidateLifetime = true,
                ValidAudience = configuration["jwt:audience"].ToString(),
                ValidateAudience = false,
                RequireSignedTokens = true,
                IssuerSigningKey = signingKey
            };

            //services.AddAuthentication(options =>
            //{
            //    //options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    //options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(configureOptions =>
            //{
            //    configureOptions.RequireHttpsMetadata = false;
            //    configureOptions.SaveToken = true;
            //    //configureOptions.ClaimsIssuer = configuration["jwt:issuer"].ToString();
            //    configureOptions.TokenValidationParameters = tokenValidationParams;
            //});
        }

        public static UserSessionEntity ValidateToken(UserSessionEntity userEntity,
               string audienceUri,
               string issuerUri,
               Guid applicationId,
               DateTime expires,
               string secretKey = null,
               bool isReAuthToken = false)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);

            var claims = new List<Claim>();

            claims.Add(new Claim("Email", userEntity.Email));
            claims.Add(new Claim("UserName", userEntity.UserName));
            claims.Add(new Claim("UserId", userEntity.UserId.ToString()));
            claims.Add(new Claim("RoleId", userEntity.RoleId == null || userEntity.RoleId <= 0 ? string.Empty : userEntity.RoleId.ToString()));
            //claims.Add(new Claim("IsManagement", userEntity.IsManagement.ToString()));
            //claims.Add(new Claim("AssignedBusinessUnit", userEntity.AssignedBusinessUnit));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = AppConstants.DateTime.AddMinutes(600),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            userEntity.UserToken = tokenHandler.WriteToken(token);
            userEntity.VallidTo = Convert.ToDateTime(tokenDescriptor.Expires);
            return userEntity;
        }
    }

    public class JwtOptions
    {
        public string secretKey { get; set; }
        public string issuer { get; set; }
        public bool validateLifetime { get; set; }
    }
}
