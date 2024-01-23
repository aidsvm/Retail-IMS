using CoreBusiness;

namespace UseCases
{
    public interface IViewCategories
    {
        IEnumerable<Category> Execute();
    }
}