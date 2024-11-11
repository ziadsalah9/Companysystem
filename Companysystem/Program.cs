using Companysystem.MapProfile;
using Companysystem.SalesForms;
using Microsoft.Extensions.DependencyInjection;

namespace Companysystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {




            var services = new ServiceCollection();
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddTransient<BillsForms>();
            services.AddTransient<Form1>();
            var serviceProvider = services.BuildServiceProvider();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();

            var mainForm = serviceProvider.GetRequiredService<BillsForms>();
          //var main = serviceProvider.GetRequiredService<Form1>();
          //  var main = serviceProvider.GetRequiredService<HomeForm>();



            // Application.Run(new Form1());
            Application.Run(new HomeForm());


        }

  

    }
}