using System;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IProductRepository productRepository;

        public DeleteProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void Delete(int productId)
        {
            productRepository.DeleteProduct(productId);
        }
    }
}

