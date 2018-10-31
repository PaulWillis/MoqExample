using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moqexample
{
    public class Product
    {
        public int ProductId{ get; set; }
        public string ProductName { get; set; }
    }

    public interface IProductRepository
    {
        IList<Product> GetProducts();

        Product FindByName(string productName);

    }


    public class ProductRepository : IProductRepository
    {
     
        public IList<Product> GetProducts()
        {
            var listOfProducts = new List<Product>();
            listOfProducts.Add(new Product { ProductId = 1, ProductName = "asdf" });
            return listOfProducts;
        }

        public Product FindByName(string productName)
        {
            return new Product { ProductId = 1, ProductName = "qefqw3e4" };
        }
         
    }

    public class ProductController
    {
        IProductRepository repository;

        public ProductController(IProductRepository repository)
        {
            this.repository = repository;
        }

        public void MethodToTest()
        {
            var products = this.repository.GetProducts();
            foreach(var prod in products)
            {
                if (prod.ProductName == "asdf")
                {
                    Console.WriteLine("awesome");
                }
            }
        }
    }




}
