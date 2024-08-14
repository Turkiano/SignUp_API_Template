using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_API_Server.src.Abstractions
{
    public interface IProductRepository
    {
        public Product FindOne(string productId);

        public List<Product> FindAll();


        public Product CreateOne(Product product);



    }
}