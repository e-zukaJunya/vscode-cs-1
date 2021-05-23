using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace vscode_cs_1
{
    class Program
    {
        static void Main(string[] args)
        {
        IServiceCollection services = new ServiceCollection();
        // Startup.cs finally :)
        Startup startup = new Startup();
        startup.ConfigureServices(services);
        IServiceProvider serviceProvider = services.BuildServiceProvider();

        //configure console logging
        // serviceProvider
        //     .GetService<ILoggerFactory>().CreateLogger();

        var logger = serviceProvider.GetService<ILoggerFactory>()
            .CreateLogger<Program>();

        logger.LogDebug("Logger is working!");
        logger.LogInformation("Info log!");
        logger.LogError("Error log!");

        // Get Service and call method
        var service = serviceProvider.GetService<IMyService>();
        service.MyServiceMethod();
        }
    }
}
