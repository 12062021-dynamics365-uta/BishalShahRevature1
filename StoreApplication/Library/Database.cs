using System;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using Storage;

namespace Storage
{
    public class Database
    {
        string query;
        string dbSource = "Data source =DESKTOP-DN2IV14\\SQLEXPRESS01;initial Catalog=StoreLocations2; integrated security =true";
        private readonly SqlConnection connection;

        public Database()
        {
            this.connection = new SqlConnection(dbSource);
            connection.Open();
        }


      
    }
}
