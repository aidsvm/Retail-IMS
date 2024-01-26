using System;
using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
	public interface IProductRepository
	{
        IEnumerable<Product> GetProducts();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        Product GetProductById(int productId);
        void DeleteProduct(int productId);

    }
}

