using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_API_Server.src.Abstractions
{
    public interface IProductRepository
    {
        public Product findOne(string productId);


    }
}