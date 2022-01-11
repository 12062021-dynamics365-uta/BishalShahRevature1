using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace SweetnSaltyDbAccess
{
    public class SweetnSaltyDbAccessClass : ISweetnSaltyDbAccessClass
    {
        private readonly string str = "Data source =DESKTOP-DN2IV14\\SQLEXPRESS01;initial Catalog=SweetnSaltyAPI; integrated security =true";
        private readonly SqlConnection _con;

        //constructor to establish connection with the db
        public SweetnSaltyDbAccessClass()
        {
            this._con = new SqlConnection(this.str);
            _con.Open();
        }
        public async Task<SqlDataReader> PostFlavor(string flavorName)
        {
            string sqlQuery = $"INSERT INTO Flavors (flavorName) VALUES ('{flavorName}');";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, _con))
            {

                cmd.Parameters.AddWithValue("@flavorName", flavorName);

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    string retrieveFlavor = "SELECT TOP 1 * FROM Flavors ORDER BY flavorID DESC";
                    using (SqlCommand cmd1 = new SqlCommand(retrieveFlavor, _con))
                    {

                        SqlDataReader dr = await cmd1.ExecuteReaderAsync();
                        return dr;
                    }
                }
                catch (DbException ex)// TODO do something with this exception
                {
                    Console.WriteLine($"There is an exception.");
                    return null;


                }
            }
        }

        public async Task<SqlDataReader> PostPerson(string firstName, string lastName)
        {
            string sqlQuery = $"INSERT INTO Person VALUES (@firstName, @lastName);";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, _con))
            {
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    string currentPerson = "SELECT TOP 1 * FROM Person ORDER BY personID DESC";
                    using (SqlCommand cmd1 = new SqlCommand(currentPerson, _con))
                    {

                        SqlDataReader dr = await cmd1.ExecuteReaderAsync();
                        return dr;
                    }
                }
                catch (DbException ex)// TODO do something with this exception
                {
                    Console.WriteLine($"There is an exception.");
                    return null;


                }
            }
        }
        public async Task<SqlDataReader> GetPerson(string firstName, string lastName)
        {
            string SqlQuery = $"SELECT* FROM Person WHERE firstName = ('{firstName}), ('{lastName}');";
            try
            {
                using (SqlCommand cmd = new SqlCommand(SqlQuery, this._con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    SqlDataReader dr = await cmd.ExecuteReaderAsync();
                    return dr;
                }
            }
            catch (DbException ex)
            {
                Console.WriteLine($"There was an exception.");
                return null;
            }
            

        }

        public async Task<List<SqlDataReader>> GetAllFlavors()
        {
            string SqlQuery = "SELECT * FROM Flavors;";
            try
            {
                using (SqlCommand cmd = new SqlCommand(SqlQuery, _con))
                {
                    SqlDataReader sdr = await cmd.ExecuteReaderAsync();
                    //convert output to list
                    return null;
                }
            }
            catch (DbException ex)//leave a message 
            {
                Console.WriteLine($"There was an exception. ");
                return null;
            }
        }
        public async Task<SqlDataReader> GetPersonAndFlavors(int personID)
        { 
            string SqlQuery = "SELECT Person.personID, Person.firstName, Person.lastName, Flavors.flavorID, FLavors.flavorName FROM Person " +
                           "JOIN PersonFlavorJunction ON Person.personID = PersonFlavorJunction.personID " +
                           "JOIN Flavors ON Flavors.flavorID = PersonFlavorJunction.flavorID " +
                           "WHERE Person.personID = @personID;";
            try 
            {
                using (SqlCommand cmd = new SqlCommand(SqlQuery, _con))
                {
                    cmd.Parameters.AddWithValue("@personID", personID);
                    SqlDataReader sdr = await cmd.ExecuteReaderAsync();
                    return sdr;
                }
            }
            catch (DbException ex)//leave a message 
            {
                Console.WriteLine($"There was an exception. ");
                return null;
            }
        }
    }
}


       