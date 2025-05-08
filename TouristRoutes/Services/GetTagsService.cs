
using TouristRoutes.Enums;
using TouristRoutes.Models;

namespace TouristRoutes.Services
{
    public class GetTagsService
    {
        private AppDbContext _dbContext;

        public GetTagsService()
        {
            _dbContext = new AppDbContext();
        }

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
