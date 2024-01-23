using CoreBusiness;

namespace UseCases
{
    public interface IGetCategoryByldUseCase
    {
        Category Execute(int categoryId);
    }
}