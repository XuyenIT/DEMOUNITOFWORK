﻿using DEMOUNITOFWORK.Models;

namespace DEMOUNITOFWORK.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProduct (int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
