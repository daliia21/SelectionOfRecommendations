using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristRoutes.Models.TagModels;

namespace TouristRoutes.Services
{
    public class FillTagsService
    {
        private AppDbContext _dbContext;

        public FillTagsService()
        {
            _dbContext = new AppDbContext();
        }

        public void FillAgeTags()
        {
            List<string> ageTags = new List<string> { "до 18", "от 18 до 25", "от 25 до 36", "от 36 до 50", "50+" };
            foreach (string t in ageTags)
            {
                _dbContext.AgeTags.Add(new AgeTag { TagName = t });
            }
        }

        public void FillBudgetTags()
        {
            List<string> budgetTags = new List<string> { "Эконом (до 30 тыс. руб.)", "Средний (от 30 - 70 тыс. руб.)", "Премиум (70+ тыс. руб.)"};
            foreach (string t in budgetTags)
            {
                _dbContext.BudgetTags.Add(new BudgetTag { TagName = t });
            }
        }

        public void FillDurationTags()
        {
            List<string> durationTags = new List<string> { "1-3 дня", "5-7 дней", "10+ дней" };
            foreach (string t in durationTags)
            {
                _dbContext.DurationTags.Add(new DurationTag { TagName = t });
            }
        }

        public void FillLevelOfTrainingTags()
        {
            List<string> levelOfTrainingTags = new List<string> { "Новичок", "Любитель", "Профессионал" };
            foreach (string t in levelOfTrainingTags)
            {
                _dbContext.LevelOfTrainingTags.Add(new LevelOfTrainingTag { TagName = t });
            }
        }

        public void FillLocationTags()
        {
            List<string> locationTags = new List<string> { "Горные районы", "Лесные зоны", "Прибрежные регионы", "Исторические места", "Экзотические направления" };
            foreach (string t in locationTags)
            {
                _dbContext.LocationTags.Add(new LocationTag { TagName = t });
            }
        }

        public void FillPurposeTags()
        {
            List<string> purposeTags = new List<string> { "Отдых", "Обучение", "Культурное обогащение" };
            foreach (string t in purposeTags)
            {
                _dbContext.PurposeTags.Add(new PurposeTag { TagName = t });
            }
        }

        public void FillSeasonTags()
        {
            List<string> seasonTags = new List<string> { "Лето", "Осень", "Зима", "Весна" };
            foreach (string t in seasonTags)
            {
                _dbContext.SeasonTags.Add(new SeasonTag { TagName = t });
            }
        }

        public void FillTypeOfTourismTags()
        {
            List<string> typeOfTourismTags = new List<string> { "Лето", "Осень", "Зима", "Весна" };
            foreach (string t in typeOfTourismTags)
            {
                _dbContext.TypeOfTourismTags.Add(new TypeOfTourismTag { TagName = t });
            }
        }
    }
}
