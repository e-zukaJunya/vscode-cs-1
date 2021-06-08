using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;

namespace BatchCommon
{
    public static class Startup
    {
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    //外部ファイルの値や環境変数の取得
                    var Configuration = new ConfigurationBuilder()
                            .AddEnvironmentVariables()
                            .Build();
                    services.Configure<Settings>(Configuration);
                    //サービスの登録
                    services.AddSingleton<IStepA2Service, StepA2Service>();
                });
    }
}
