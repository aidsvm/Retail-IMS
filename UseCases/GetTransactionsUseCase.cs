using System;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetTransactionsUseCase : IGetTransactionsUseCase
    {
        private readonly ITransactionRepository transactionRepository;

        public GetTransactionsUseCase(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }

        public IEnumerable<Transaction> Execute(
            string cashierName,
            DateTime startDate,
            DateTime endDate)
        {
            return transactionRepository.Search(cashierName, startDate, endDate);
        }
    }
}

