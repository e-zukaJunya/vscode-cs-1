namespace BatchCommon
{
    /// <summary>
    /// アプリケーション設定
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// RDS接続文字列
        /// </summary>
        public string RdsConnectionString { get; set; }

        public string MY_ENV { get; set; }
    }
}
