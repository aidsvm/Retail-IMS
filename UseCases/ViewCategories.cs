using System;
using CoreBusiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class ViewCategories : IViewCategories
    {
        private readonly ICategoryRepository categoryRepository;

        public ViewCategories(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> Execute()
        {
            return categoryRepository.GetCategories();


        }
    }
}

