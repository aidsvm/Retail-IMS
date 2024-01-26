using CoreBusiness;

namespace UseCases.UseCaseInferfaces
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int ProductId);
    }
}