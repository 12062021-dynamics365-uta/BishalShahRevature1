using StoreApplication;
using System;
using System.Collections.Generic;
using Xunit;
using Domain;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            //Arrange
                MockDataBase connect = new MockDataBase();
            //Act
                List<Customer> customers = connect.GetCustomer();
            //Assert
                Assert.Equal(2, customers.Count);
            
        }
        [Fact]
        public void Test2()
        {

            //Arrange
            MockDataBase connect = new MockDataBase();
            //Act
            List<Product> products = connect.GetProducts();
            //Assert
            Assert.Equal(2, products.Count);

        }
    }
}
