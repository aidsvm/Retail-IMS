using System;
using CoreBusiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {
            categories = new List<Category>()
            {
                new Category { CategoryId = 1, Name = "Produce", Description = "Produce"},
                new Category { CategoryId = 2, Name = "Meat", Description = "Meat"},
                new Category { CategoryId = 3, Name = "Seafood", Description = "Seafood"},
                new Category { CategoryId = 4, Name = "Deli", Description = "Deli"},
                new Category { CategoryId = 5, Name = "Bakery", Description = "Bakery"}

            };
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }
            

            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);
            if (categoryToUpdate != null) categoryToUpdate = category;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public void DeleteCategory(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId));
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

     
    }

}



