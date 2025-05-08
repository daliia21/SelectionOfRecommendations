using Microsoft.EntityFrameworkCore;
using TouristRoutes.Services;

namespace TouristRoutes
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new AppDbContext())
            {
                bool databaseExist = context.Database.CanConnect();

                if (!databaseExist)
                {
                    context.Database.Migrate();

                    FillTagsService tagsService = new FillTagsService();
                    tagsService.FillTags();
                }
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            Application.Run(new AccountForm());
        }
    }
}