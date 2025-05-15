using Microsoft.EntityFrameworkCore;
using NLog;
using System.Text.Json;
using System.Text.Json.Serialization;
using TouristRoutes.Forms;
using TouristRoutes.Models;
using TouristRoutes.Services;

namespace TouristRoutes
{
    internal static class Program
    {
        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logger.Info("Main запустился");

            using (var context = new AppDbContext())
            {
                var databaseExist = context.Database.CanConnect();

                if (!databaseExist)
                {
                    context.Database.Migrate();
                    Logger.Info("Миграции применились");

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        Converters = { new JsonStringEnumConverter() } 
                    };

                    var json = File.ReadAllText("tags.json");
                    var tagGroups = JsonSerializer.Deserialize<List<TagGroup>>(json, options);

                    
                   var tags = tagGroups
                        .SelectMany(group => group.TagName.Select(name => new Tag
                        {
                            TagName = name,
                            TagType = group.TagType
                        }))
                        .ToList();

                    var tagsService = new FillTagsService();
                    tagsService.FillTags(tags);
                }
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            Application.Run(new AccountForm());
        }
    }
}