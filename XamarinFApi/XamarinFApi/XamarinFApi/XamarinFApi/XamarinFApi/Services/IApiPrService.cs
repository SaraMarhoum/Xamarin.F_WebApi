using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinFApi.Models;

namespace XamarinFApi.Services
{
    public interface IApiPrService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task AddProduct(Product product);
        Task SaveProduct(Product product);
        Task DeleteProduct(Product product);
    }
}
