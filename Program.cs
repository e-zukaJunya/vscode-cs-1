using BatchCommon;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StepA2
{
    class Program
    {
        /// <summary>
        /// サンプルバッチ
        /// </summary>
        /// <param name="args">引数</param>
        /// <returns>なし</returns>
        static async Task Main(string[] args)
        {
            //DIコンテナのセットアップ
            using IHost host = Startup.CreateHostBuilder(args).Build();

            //必要なサービスの取得
            var mainService = host.Services.GetRequiredService<IStepA2Service>();
            var logger = host.Services.GetRequiredService<ILogger<Program>>();

            //実際のメイン処理の実行
            mainService.Main();

            //ログ試し
            logger.LogInformation("呼び出し元！");

            var a = new List<string>() { "Hello","World"};
            // List<string> a = new List<string>() { "Hello","World"};
            var b = a.ToArray();
            for (var f = 1;f < b.Length;f++) {
                Console.WriteLine(value: b[f].ToString());
            }
            //最後に毎回書く
            await host.RunAsync();
            return;
        }
    }
}
