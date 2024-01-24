using System;
using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
	public interface IProductRepository
	{
        IEnumerable<Product> GetProducts();
    }
}

