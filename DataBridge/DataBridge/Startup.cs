using DataBridge.Infrastructure;
using DataBridge.InputTypes;
using DataBridge.Interfaces;
using DataBridge.Mutations;
using DataBridge.Queries;
using DataBridge.Repositories;
using DataBridge.Schemas;
using DataBridge.Shared.Entities;
using DataBridge.Types;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace DataBridge
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICustomConnectionFactory, ConnectionFactory>();

            services.AddScoped<IRepository<Company>, CompanyRepository>();
            services.AddScoped<IRepository<User>, UserRepository>();
            services.AddScoped<IRepository<Factory>, FactoryRepository>();

            services.AddTransient<CompanyType>();
            services.AddTransient<UserType>();
            services.AddTransient<FactoryType>();

            services.AddTransient<CompanyInputType>();
            services.AddTransient<UserInputType>();
            services.AddTransient<FactoryInputType>();

            services.AddTransient<CompanyQuery>();
            services.AddTransient<UserQuery>();
            services.AddTransient<FactoryQuery>();

            services.AddTransient<CompanyMutation>();
            services.AddTransient<UserMutation>();
            services.AddTransient<FactoryMutation>();

            services.AddScoped<CompanySchema>();
            services.AddScoped<UserSchema>();
            services.AddScoped<FactorySchema>();

            services.AddGraphQL()
               .AddSystemTextJson()
               .AddGraphTypes(typeof(CompanySchema), ServiceLifetime.Scoped)
               .AddGraphTypes(typeof(UserSchema), ServiceLifetime.Scoped)
               .AddGraphTypes(typeof(FactorySchema), ServiceLifetime.Scoped);

            services.AddMvc(x => x.EnableEndpointRouting = false);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DataBridge", Version = "v1" });
            });

            services.Configure<KestrelServerOptions>(o => o.AllowSynchronousIO = true);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DataBridge v1"));
            }

            app.UseMvc();

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseGraphQL<CompanySchema>(path: "/graphql/companies");
            app.UseGraphQL<UserSchema>(path: "/graphql/users");
            app.UseGraphQL<FactorySchema>(path: "/graphql/factories");

            app.UseGraphQLPlayground(/*options: new GraphQLPlaygroundOptions()*/);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
