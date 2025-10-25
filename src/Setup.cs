using BugStore.Application.Domain.Commands.Customer.Create;
using BugStore.Data;
using BugStore.Data.Transactions;
using BugStore.Domain.Domain.Contracts.Repositories;
using BugStore.Infra.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace BugStore.Api
{
    public static class Setup
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
            services.AddTransient<IConfigureOptions<SwaggerUIOptions>, ConfigureSwaggerUIOptions>();
            //services.AddSwaggerGen();
            services.AddSwaggerGen(c =>
            {
                // Garante que cada operação tenha um ID único
                c.CustomOperationIds(apiDesc =>
                {
                    return $"{apiDesc.ActionDescriptor.RouteValues["controller"]}_{apiDesc.ActionDescriptor.RouteValues["action"]}";
                });
            });

        }
        public static void ConfigureUploadLimitToMaximum(this IServiceCollection services)
        {
            services.Configure<FormOptions>(options =>
            {
                options.ValueLengthLimit = int.MaxValue; //not recommended value
                options.MultipartBodyLengthLimit = long.MaxValue; //not recommended value
            });
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            //services.AddTransient<IServiceEmail, Infra.Services.ServiceEmail.ServiceEmail>();
            //services.AddTransient<IServicePushNotification, ServicePushNotification>();
            //services.AddTransient<IServiceGlobalBus, ServiceGlobalBus>();
            //services.AddTransient<IServiceEmail, ServiceEmail>();
        }
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext, AppDbContext>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //Services
            //services.AddTransient<IServiceCanal, ServiceCanal>();
            
            //Repositories
            services.AddTransient<IRepositoryCustomer, RepositoryCustomer>();
            
        }
        public static void ConfigureCompression(this IServiceCollection services)
        {
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "application/json" });
            });
        }
        public static void ConfigureAuthentication(this IServiceCollection services)
        {
            //services.AddSingleton<ITokenManager, TokenManager>();
            //var key = Encoding.ASCII.GetBytes(Settings.Secret);
            //services.AddAuthentication(x =>
            //{
            //    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //.AddJwtBearer(x =>
            //{
            //    x.RequireHttpsMetadata = false;
            //    x.SaveToken = true;
            //    x.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(key),
            //        ValidateIssuer = false,
            //        ValidateAudience = false
            //    };
            //});

            //Configuração do Token
            //var signingConfigurations = new SigningConfigurations();
            //services.AddSingleton(signingConfigurations);


            //var tokenConfigurations = new TokenConfigurations
            //{
            //    Audience = "c6bbbb645024",
            //    Issuer = "c1f51f42",
            //    Seconds = int.Parse(TimeSpan.FromDays(2).TotalSeconds.ToString())

            //};
            //services.AddSingleton(tokenConfigurations);


            //services.AddAuthentication(authOptions =>
            //{
            //    authOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    authOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(bearerOptions =>
            //{
            //    var paramsValidation = bearerOptions.TokenValidationParameters;
            //    paramsValidation.IssuerSigningKey = signingConfigurations.SigningCredentials.Key;
            //    paramsValidation.ValidAudience = tokenConfigurations.Audience;
            //    paramsValidation.ValidIssuer = tokenConfigurations.Issuer;

            //    // Valida a assinatura de um token recebido
            //    paramsValidation.ValidateIssuerSigningKey = true;

            //    // Verifica se um token recebido ainda é válido
            //    paramsValidation.ValidateLifetime = true;

            //    // Tempo de tolerância para a expiração de um token (utilizado
            //    // caso haja problemas de sincronismo de horário entre diferentes
            //    // computadores envolvidos no processo de comunicação)
            //    paramsValidation.ClockSkew = TimeSpan.Zero;
            //});

            //// Ativa o uso do token como forma de autorizar o acesso
            //// a recursos deste projeto
            //services.AddAuthorization(auth =>
            //{
            //    auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
            //        .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme‌​)
            //        .RequireAuthenticatedUser().Build());
            //});

            ////Para todas as requisições serem necessaria o token, para um endpoint não exisgir o token
            ////deve colocar o [AllowAnonymous]
            ////Caso remova essa linha, para todas as requisições que precisar de token, deve colocar
            ////o atributo [Authorize("Bearer")]
            //services.AddMvc(config =>
            //{
            //    var policy = new AuthorizationPolicyBuilder()
            //        .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme‌​)
            //        .RequireAuthenticatedUser().Build();

            //    config.Filters.Add(new AuthorizeFilter(policy));
            //});

            //services.AddCors();
        }
        public static void ConfigureContextEF(this IServiceCollection services, string connection)
        {
            //services.AddDbContext<Context>(options =>
            //{
            //    options.UseMySql(connection, ServerVersion.AutoDetect(connection));
            //});

        }

        public static void ConfigureMediatR(this IServiceCollection services)
        {
            services.AddMediatR(typeof(Program).GetTypeInfo().Assembly, typeof(CreateRequest).GetTypeInfo().Assembly);


        }
    }
}
