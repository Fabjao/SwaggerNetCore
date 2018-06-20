using ApiTesteSwagger.Business;
using ApiTesteSwagger.Contract;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace ApiTesteSwagger
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<IPessoa, PessoaBusiness>();
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Info() { Version = "1", Title = "Minha API" });
                s.IncludeXmlComments(@"bin\Debug\netcoreapp2.0\ApiTesteSwagger.xml");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(C =>
            {
                C.SwaggerEndpoint("/swagger/v1/swagger.json", "Minha API de Pessoa");
                C.RoutePrefix = string.Empty;

            });
            app.UseMvc();
        }
    }
}
