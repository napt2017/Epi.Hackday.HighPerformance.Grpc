using DB.Access;
using DB.Access.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SOAP.Server.Interfaces;
using SoapCore; 
using System.ServiceModel; 

namespace SOAP.Server
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSoapCore();
            services.AddDbContext<EpiHackdayDbContext>(options => options.UseSqlite(@"Data Source=C:\Users\TheCodeNameOne\Desktop\hackday.db"));
            services.AddScoped<IEpiHackdayRepository, EpiHackdayRepository>();
            services.AddScoped<IHackdayTopicOperation, SOAP.Server.HackdayTopicOperation.HackdayTopicOperation>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });

            app.UseSoapEndpoint<IHackdayTopicOperation>("/HackdayTopic.svc", new BasicHttpBinding(), SoapSerializer.XmlSerializer);
        }
    }
}
