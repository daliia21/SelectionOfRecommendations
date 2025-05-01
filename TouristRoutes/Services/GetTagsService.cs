using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristRoutes.Models.TagModels;

namespace TouristRoutes.Services
{
    public class GetTagsService
    {
        private AppDbContext _dbContext;

        public GetTagsService()
        {
            _dbContext = new AppDbContext();
        }

        public List<AgeTag> GetAgeTags()
        {
            return _dbContext.AgeTags.ToList();             
        }

        public List<BudgetTag> GetBudgetTags()
        {
            return _dbContext.BudgetTags.ToList();
        }

        public List<DurationTag> GetDurationTags()
        {
            return _dbContext.DurationTags.ToList();
        }

        public List<LevelOfTrainingTag> GetLevelOfTrainingTags()
        {
            return _dbContext.LevelOfTrainingTags.ToList();
        }

        public List<LocationTag> GetLocationTags()
        {
            return _dbContext.LocationTags.ToList();
        }

        public List<PurposeTag> GetPurposeTags()
        {
            return _dbContext.PurposeTags.ToList();
        }

        public List<SeasonTag> GetSeasonTags()
        {
            return _dbContext.SeasonTags.ToList();
        }

        public List<TypeOfTourismTag> GetTypeOfTourismTags()
        {
            return _dbContext.TypeOfTourismTags.ToList();
        }
    }
}
