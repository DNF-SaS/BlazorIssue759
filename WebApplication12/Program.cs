using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Runtime.CompilerServices;

namespace WebApplication12
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                // Add any custom services here
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }

		public static void Log(string message, [CallerMemberName] string member = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int line = 0)
		{
			//var file = Path.GetFileName(filePath);
			var file = filePath.Contains(@"\") ? filePath.Substring(filePath.LastIndexOf('\\') + 1) : filePath;
			Console.WriteLine($"{message} - {member} @ {file}:{line}");
		}
	}
}
