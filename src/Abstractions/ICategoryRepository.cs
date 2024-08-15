using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop_API_Server.src.Abstractions
{
    public interface ICategoryRepository
    {
        public List<Category> FindAll();

    }
}