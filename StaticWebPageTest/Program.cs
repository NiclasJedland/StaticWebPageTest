using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace StaticWebPageTest
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//var host = new WebHostBuilder()
			//    .UseKestrel()
			//    .UseContentRoot(Directory.GetCurrentDirectory())
			//    .UseIISIntegration()
			//    .UseStartup<Startup>()
			//    .Build();
			var host = new WebHostBuilder()
				.UseKestrel()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseSetting("detailedErrors", "true")
				.UseIISIntegration()
				.UseStartup<Startup>()
				.CaptureStartupErrors(true)
				.Build();
			host.Run();
		}
	}
}
