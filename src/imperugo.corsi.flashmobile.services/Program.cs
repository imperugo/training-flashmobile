﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace imperugo.corsi.flashmobile.services
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
				.UseKestrel(options =>
	            {
		            //options.UseHttps("Configuration\\mycert.pfx", "mypassword");
	            })
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            host.Run();
        }
    }
}
