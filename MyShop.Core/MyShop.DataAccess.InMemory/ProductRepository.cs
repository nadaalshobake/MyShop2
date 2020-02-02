using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using MyShop.Core;

namespace MyShop.DataAccess.InMemory
{
    class ProductRepository
    {

        ObjectCache cache = MemoryCache.Default;
        List<Product> products;
        public ProductRepository()
        {




            products = cache["products"] as List<Product>;
            if (products == null)
            {
                products = new List<Product>();


            }

        }
        public void Commit()
        {

            cache["products"] = products;

        }
        public void Insert(Product p)
        {
            products.Add(p);



        }

        public void Update(Product product)
        {


            Product productTOUpdate = products.Find(p => p.ID == product.ID);
            if (productTOUpdate != null)
            {





                productTOUpdate = product;
            }
            else
            {
                throw new Exception("Product no found ");


            }
        }



        public Product find(String Id)
        {


            Product product = products.Find(p => p.ID == Id);

            if (product != null)
            {

                return product;

            }
            else
            {


                throw new Exception("product not found");
            }

        }



        public IQueryable<Product> Collection()
        {


            return products.AsQueryable();



        }



        public void Delete(string id)
        {




            Product productToDelete = products.Find(p => p.ID == id);

            if (productToDelete != null)
            {

                products.Remove(productToDelete);

            }
            else
            {


                throw new Exception("product not found");
            }


        }



    }

}
