using StoreApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MockDataBase
    {
        public List<Customer> GetCustomer()
        {
            List<Customer> customers = new List<Customer>();
            Customer c1 = new Customer()
            {
                customerId = 1,
                firstName = "Peter",
                lastName = "Quill",
                username = "P.Quill",
                password = "12345",
            };
            Customer c2 = new Customer()
            {
                customerId = 2,
                firstName = "Peter",
                lastName = "Parker",
                username = "Peter.Parker",
                password = "peterparker1",
            };
            customers.Add(c1);
            customers.Add(c2);
            return customers;
        }
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            Product p1 = new Product()
            {
                ProductId = 1,
                ProductName = "Cup Holder",
                ProductDescription = "3-D Printed Cup Holder",
                ProductPrice = 50
            };
            Product p2 = new Product()
            {
                ProductId = 10,
                ProductName = "DND Dices",
                ProductDescription = "3-D Printed DND Dices",
                ProductPrice = 100
            };
            
            products.Add(p1);
            products.Add(p2);
            return products;
        }
    }
}
