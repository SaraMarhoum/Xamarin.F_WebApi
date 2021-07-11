using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinFApi.Models;

namespace XamarinFApi.Services
{
    public class DbApiService : IApiPrService
    {
        private readonly List<Product> _product = new List<Product>();

        public DbApiService()
        {
            _product.Add(new Product { Id = 1, Name = "Hp", Price = 12000, Description = "Laptop" });
            _product.Add(new Product { Id = 2, Name = "Samsung", Price = 6000, Description = "Laptop" });
            _product.Add(new Product { Id = 3, Name = "Dell", Price = 8500, Description = "Laptop" });
        }

        public Task AddProduct(Product product)
        {
            product.Id = ++_product.Last().Id;
            _product.Add(product);
            return Task.CompletedTask;
        }

        public Task DeleteProduct(Product product)
        {
            _product.Remove(product);
            return Task.CompletedTask;
        }

        public Task<Product> GetProduct(int id)
        {
            var product = _product.FirstOrDefault(b => b.Id == id);
            return Task.FromResult(product);
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            return Task.FromResult(_product.AsEnumerable());
        }

        public Task SaveProduct(Product product)
        {
            _product[_product.FindIndex(b => b.Id == product.Id)] = product;
            return Task.CompletedTask;
        }
    }
}
