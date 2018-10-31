using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using moqexample;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace Test.MoqEx
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { 

            var listOfProducts = new List<Product>();
            listOfProducts.Add(new Product { ProductId = 21, ProductName = "mockasdfa dsf asd" }); 


            Mock<IProductRepository> mockrep = new Mock<IProductRepository>();
            mockrep.Setup(x => x.GetProducts()).Returns(listOfProducts);
            var productController = new ProductController(mockrep.Object);
            productController.MethodToTest();
            Assert.IsNotNull(productController);
        }
    }
}
