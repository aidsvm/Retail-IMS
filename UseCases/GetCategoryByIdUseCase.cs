using System;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetCategoryByldUseCase : IGetCategoryByldUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public GetCategoryByldUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public Category Execute(int categoryId)
        {
            return categoryRepository.GetCategoryById(categoryId);
        }
    }
}

