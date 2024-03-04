using CRUDDapper.Datos;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System.Configuration;

namespace CRUDDapper
{
   
    internal static class Program
    {


        // internal static IConfiguration Configuration = null;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           var configuration = new ConfigurationBuilder()
                     .AddJsonFile("appsettings.json")
                      .Build();
            var servicecolletion = new ServiceCollection();
            servicecolletion.AddScoped<ICategoriesDatos, CategoriesDatos>();
            servicecolletion.AddScoped<ISqlConnectionFactory, SqlConnectionFactory>();
            servicecolletion.AddScoped<CategoryForm>();
            servicecolletion.AddScoped<Form1>();
            servicecolletion.AddScoped<IConfiguration>((s) => configuration);
            var serviceprovaider = servicecolletion.BuildServiceProvider();
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();



            int a = 10, b = 0;
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.

                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                Application.ThreadException += Application_ThreadException;
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                //  var mainform = serviceprovaider.GetService<CategoryForm>();
                var mainform = serviceprovaider.GetService<Form1>();
                Application.Run(mainform);
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }
            finally
            {
                Log.CloseAndFlushAsync();
            }
          
          
                

        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            LogExceptionAndShowCustomMEssage(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            LogExceptionAndShowCustomMEssage((Exception)e.ExceptionObject);
        }
        private static void LogExceptionAndShowCustomMEssage(Exception ex)
        {
            //Registra la excepción en los registros
            Log.Error(ex, "Error ");
            MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}