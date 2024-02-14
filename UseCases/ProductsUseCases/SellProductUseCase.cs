using System;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class SellProductUseCase : ISellProductUseCase
    {
        private readonly IProductRepository productRepository;
        private readonly IRecordTransactionsUseCase recordTransactionsUseCase;

        public SellProductUseCase(
            IProductRepository productRepository,
            IRecordTransactionsUseCase recordTransactionsUseCase)
        {
            this.productRepository = productRepository;
            this.recordTransactionsUseCase = recordTransactionsUseCase;
        }

        public void Execute(string cashierName, int productId, int qtyToSell)
        {
            var product = productRepository.GetProductById(productId);
            if (product == null) return;

            recordTransactionsUseCase.Execute(cashierName, productId, qtyToSell);

            product.Quantity -= qtyToSell;
            productRepository.UpdateProduct(product);
            
        }

    }
}

