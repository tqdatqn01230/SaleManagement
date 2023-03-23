using Microsoft.Extensions.Configuration;
using SaleWinApp;

namespace SalesWinApp
{
    internal static class Program
    {
        public static IConfigurationRoot Configuration { get; private set; }
        
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           /* ApplicationConfiguration.Initialize();*/

            Application.Run(new frmLogin());
        }
    }
}