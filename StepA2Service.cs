using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BatchCommon
{
    /// <summary>
    /// インターフェース
    /// </summary>
    public interface IStepA2Service
    {
        /// <summary>
        /// このバッチのメイン処理
        /// </summary>
        void Main();
    }

    /// <summary>
    /// サンプルバッチ service
    /// </summary>
    public class StepA2Service : IStepA2Service
    {
        /// <summary>
        /// アプリケーション設定
        /// </summary>
        private readonly Settings _config;

        /// <summary>
        /// ロガー
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="config">アプリケーション設定</param>
        /// <param name="logger">ロガー</param>
        public StepA2Service(IOptions<Settings> config, ILogger<StepA2Service> logger)
        {
            _config = config.Value;
            _logger = logger;
        }

        #region public メソッド
        /// <summary>
        /// このバッチのメイン処理
        /// </summary>
        public void Main()
        {
            _logger.LogInformation("logloglog");
            _logger.LogInformation(_config.RdsConnectionString);
        }
        #endregion
    }
}
