using TouristRoutes.Enums;
using TouristRoutes.Models;

namespace TouristRoutes.Services
{
    /// <summary>
    /// Сервис для заполнения тегов
    /// </summary>
    public class FillTagsService
    {
        private AppDbContext _dbContext;

        /// <summary>
        /// Конструктор сервиса
        /// </summary>
        public FillTagsService()
        {
            _dbContext = new AppDbContext();
        }

        /// <summary>
        /// Метод для заполнения всех тегов
        /// </summary>
        public void FillTags()
        {
            FillTagsForTagType(
                new List<string> { "до 18", "от 18 до 25", "от 25 до 36", "от 36 до 50", "50+" },
                TagType.AgeTag);

            FillTagsForTagType(
                new List<string> { "Эконом (до 30 тыс. руб.)", "Средний (от 30 - 70 тыс. руб.)", "Премиум (70+ тыс. руб.)" },
                TagType.BudgetTag);

            FillTagsForTagType(
                new List<string> { "1-3 дня", "5-7 дней", "10+ дней" },
                TagType.DurationTag);

            FillTagsForTagType(
                new List<string> { "Новичок", "Любитель", "Профессионал" },
                TagType.LevelOfTrainingTag);

            FillTagsForTagType(
                new List<string> { "Горные районы", "Лесные зоны", "Прибрежные регионы", "Исторические места", "Экзотические направления" },
                TagType.LocationTag);

            FillTagsForTagType(
                new List<string> { "Отдых", "Обучение", "Культурное обогащение" },
                TagType.PurposeTag);

            FillTagsForTagType(
                new List<string> { "Лето", "Осень", "Зима", "Весна" },
                TagType.SeasonTag);

            FillTagsForTagType(
                new List<string> { "Рекреационный", "Экскурсионный", "Приключенческий", "Спортивный", "Шопинг" },
                TagType.TypeOfTourismTag);            
        }

        private void FillTagsForTagType(List<string> tagNames, TagType tagType)
        {
            foreach (string tagName in tagNames)
            {
                _dbContext.Tags.Add(new Tag { TagName = tagName, TagType = tagType });
            }
            _dbContext.SaveChanges();
        }       
    }
}
