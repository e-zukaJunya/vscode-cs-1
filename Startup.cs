using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public class Startup
{
    IConfigurationRoot Configuration { get; }

    public Startup()
    {
        var builder = new ConfigurationBuilder();

        Configuration = builder.Build();
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddLogging();
        services.AddSingleton<IConfigurationRoot>(Configuration);
        services.AddSingleton<IMyService, MyService>();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureLogging(logging =>
        {
            logging.ClearProviders();
            logging.AddConsole();
        });
}