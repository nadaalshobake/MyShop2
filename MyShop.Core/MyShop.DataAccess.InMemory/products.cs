using System;
using System.Linq;

namespace MyShop.DataAccess.InMemory
{
    internal class products
    {
        internal static IQueryable<Product> AsQueryable()
        {
            throw new NotImplementedException();
        }

        internal static Product Find(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        internal static void Remove(Product productToDelete)
        {
            throw new NotImplementedException();
        }
    }
}