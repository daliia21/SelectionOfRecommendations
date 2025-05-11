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
            FillAgeTags();
            FillBudgetTags();
            FillDurationTags();
            FillLevelOfTrainingTags();
            FillLocationTags();
            FillPurposeTags();
            FillSeasonTags();
            FillTypeOfTourismTags();
        }

        /// <summary>
        /// Метод для заполнения тегов возраста
        /// </summary>
        private void FillAgeTags()
        {
            var ageTags = new List<string> { "до 18", "от 18 до 25", "от 25 до 36", "от 36 до 50", "50+" };
            foreach (string t in ageTags)
            {
                _dbContext.Tags.Add(new Tag { TagName = t, TagType = TagType.AgeTag });
            }

            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Метод для заполнения тегов бюджета
        /// </summary>
        private void FillBudgetTags()
        {
            var budgetTags = new List<string> { "Эконом (до 30 тыс. руб.)", "Средний (от 30 - 70 тыс. руб.)", "Премиум (70+ тыс. руб.)"};
            foreach (string t in budgetTags)
            {
                _dbContext.Tags.Add(new Tag { TagName = t, TagType = TagType.BudgetTag });
            }

            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Метод для заполнения тегов длительности
        /// </summary>
        private void FillDurationTags()
        {
            var durationTags = new List<string> { "1-3 дня", "5-7 дней", "10+ дней" };
            foreach (string t in durationTags)
            {
                _dbContext.Tags.Add(new Tag { TagName = t, TagType = TagType.DurationTag });
            }

            _dbContext.SaveChanges();

        }

        /// <summary>
        /// Метод для заполнения тегов уровня подготовки
        /// </summary>
        private void FillLevelOfTrainingTags()
        {
            var levelOfTrainingTags = new List<string> { "Новичок", "Любитель", "Профессионал" };
            foreach (string t in levelOfTrainingTags)
            {
                _dbContext.Tags.Add(new Tag { TagName = t, TagType = TagType.LevelOfTrainingTag });
            }

            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Метод для заполнения тегов расположения
        /// </summary>
        private void FillLocationTags()
        {
            var locationTags = new List<string> { "Горные районы", "Лесные зоны", "Прибрежные регионы", "Исторические места", "Экзотические направления" };
            foreach (string t in locationTags)
            {
                _dbContext.Tags.Add(new Tag { TagName = t, TagType = TagType.LocationTag });
            }

            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Метод для заполнения тегов целей
        /// </summary>
        private void FillPurposeTags()
        {
            var purposeTags = new List<string> { "Отдых", "Обучение", "Культурное обогащение" };
            foreach (string t in purposeTags)
            {
                _dbContext.Tags.Add(new Tag { TagName = t, TagType = TagType.PurposeTag });
            }

            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Метод для заполнения тегов сезона
        /// </summary>
        private void FillSeasonTags()
        {
            var seasonTags = new List<string> { "Лето", "Осень", "Зима", "Весна" };
            foreach (string t in seasonTags)
            {
                _dbContext.Tags.Add(new Tag { TagName = t, TagType = TagType.SeasonTag });
            }

            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Метод для заполнения тегов типа туризма
        /// </summary>
        private void FillTypeOfTourismTags()
        {
            var typeOfTourismTags = new List<string> { "Рекреационный", "Экскурсионный", "Приключенческий", "Спортивный", "Шопинг" };
            foreach (string t in typeOfTourismTags)
            {
                _dbContext.Tags.Add(new Tag { TagName = t, TagType = TagType.TypeOfTourismTag });
            }

            _dbContext.SaveChanges();
        }
    }
}
