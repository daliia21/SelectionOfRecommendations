﻿using TouristRoutes.Enums;
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

        /// <summary>
        /// Метод для получения тегов по типу
        /// </summary>
        public List<Tag> GetTagsForTagType(TagType tagType)
        {
            return _dbContext.Tags.Where(t => t.TagType == tagType).ToList();
        }

        /// <summary>
        /// Метод для получения всех тегов
        /// </summary>
        public List<Tag> GetAllTags()
        {
            return _dbContext.Tags.ToList();
        }
    }
}
