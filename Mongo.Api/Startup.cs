using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mongo.Api.Repositories;
using Mongo.Api.Repositories.Context;
using Mongo.Api.Services;
using Mongo.Api.Settings;

namespace Mongo.Api
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
			services.Configure<DbSettings>(
				options =>
				{
					options.ConnectString = Configuration.GetSection("Db:ConnectString").Value;
					options.Database = Configuration.GetSection("Db:Database").Value;
				});

			services.AddTransient<IRollerRepository, RollerRepository>();
			services.AddTransient<IRollerService, RollerService>();
			services.AddTransient<IRollerContext, RollerContext>();

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			var cb = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json")
				.AddEnvironmentVariables();

			if (env.IsDevelopment())
			{
				cb.AddUserSecrets<Startup>();
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseMvc();
		}
	}
}