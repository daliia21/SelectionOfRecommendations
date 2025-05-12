using TouristRoutes.Enums;
using TouristRoutes.Models;

namespace TouristRoutes.Services
{
    /// <summary>
    /// Сервис для получения тегов
    /// </summary>
    public class GetTagsService
    {
        private AppDbContext _dbContext;

        /// <summary>
        /// Конструтор сервиса
        /// </summary>
        public GetTagsService()
        {
            _dbContext = new AppDbContext();
        }

        public List<Tag> GetAllTags()
        {
            return _dbContext.Tags.ToList();
        }

        //todo
        public List<Tag> GetAgeTags()
        {
            return _dbContext.Tags.Where(t => t.TagType == TagType.AgeTag).ToList();             
        }

        public List<Tag> GetBudgetTags()
        {
            return _dbContext.Tags.Where(t => t.TagType == TagType.BudgetTag).ToList();
        }

        public List<Tag> GetDurationTags()
        {
            return _dbContext.Tags.Where(t => t.TagType == TagType.DurationTag).ToList();
        }

        public List<Tag> GetLevelOfTrainingTags()
        {
            return _dbContext.Tags.Where(t => t.TagType == TagType.LevelOfTrainingTag).ToList();
        }

        public List<Tag> GetLocationTags()
        {
            return _dbContext.Tags.Where(t => t.TagType == TagType.LocationTag).ToList();
        }

        public List<Tag> GetPurposeTags()
        {
            return _dbContext.Tags.Where(t => t.TagType == TagType.PurposeTag).ToList();
        }

        public List<Tag> GetSeasonTags()
        {
            return _dbContext.Tags.Where(t => t.TagType == TagType.SeasonTag).ToList();
        }

        public List<Tag> GetTypeOfTourismTags()
        {
            return _dbContext.Tags.Where(t => t.TagType == TagType.TypeOfTourismTag).ToList();
        }
    }
}
