using System;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
	public class ProductInMemoryRepository : IProductRepository
	{ 
		private List<Product> products;

		public ProductInMemoryRepository()
		{
			// Init with default values
			products = new List<Product>()
			{
				new Product {ProductId = 1, CategoryId = 1, Name = "Iced Tea", Quantity = 100, Price = 1.99},
				new Product { ProductId = 2, CategoryId = 2, Name = "Wheat Bread", Quantity = 250, Price = 6.99 },
                new Product {ProductId = 3, CategoryId = 5, Name = "Lemonade", Quantity = 100, Price = 4.99}
            };
		}

		public IEnumerable<Product> GetProducts()
		{
			return products;
		}
	}
}

