using System;
using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
	public interface ITransactionRepository
	{
		public IEnumerable<Transaction> Get(string cashierName);
        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date);
        public void Save(string cashierName, int productId, string productName, double price, int beforeQuantity, int soldQuantity);
	}
}

