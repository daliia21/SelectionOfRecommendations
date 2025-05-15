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
        public void FillTags(List<Tag> tags)
        {
            _dbContext.Tags.AddRange(tags);
            _dbContext.SaveChanges();
        }    
    }
}
