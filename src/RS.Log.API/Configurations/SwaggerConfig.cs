﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace RS.Log.API.Configurations
{
	public static class SwaggerConfig
	{
		public static IServiceCollection AddSwaggerConfigureServices(this IServiceCollection services)
		{
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "RS.Log.API", Version = "v1" });
			});

			return services;
		}

		public static IApplicationBuilder UseSwaggerConfigure(this IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RS.Log.API v1"));
			}

			return app;
		}
	}
}
