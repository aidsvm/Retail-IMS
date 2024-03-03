using System;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInferfaces;

namespace UseCases
{
    public class RecordTransactionsUseCase : IRecordTransactionsUseCase
    {
        private readonly ITransactionRepository transactionRepository;
        private readonly IGetProductByIdUseCase getProductByldUseCase;

        public RecordTransactionsUseCase(ITransactionRepository transactionRepository,
            UseCases.UseCaseInferfaces.IGetProductByIdUseCase getProductByldUseCase)
        {
            this.transactionRepository = transactionRepository;
            this.getProductByldUseCase = getProductByldUseCase;
        }

        public void Execute(string cashierName, int productId, int quantity)
        {
            var product = getProductByldUseCase.Execute(productId);

            transactionRepository.Save(cashierName, productId, product.Name, product.Price.Value, product.Quantity.Value, quantity);
        }
    }
}

