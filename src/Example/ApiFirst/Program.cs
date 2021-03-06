﻿using Microsoft.AspNetCore;
using Jboss.AspNetCore.Authentication.Keycloak;
using Microsoft.AspNetCore.Hosting;

namespace ApiFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKeycloak()
                .UseStartup<Startup>();
    }
}
