using DutchTreat.Data.Entities;
using System.Collections.Generic;

namespace Dutch.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);

        bool SaveChanges();
    }
}