namespace Z.Ip2Region.Net.UI.Net8.Win
{

    /// <summary>
    /// 应用程序的主入口点
    /// </summary>
    public static class Program
    {

        /// <summary>
        /// 应用程序的主入口点
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }

    }
}
