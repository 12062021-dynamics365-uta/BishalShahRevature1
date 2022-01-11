using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetnSaltyDbAccess
{
    public interface ISweetnSaltyDbAccessClass
    {
        Task<SqlDataReader> PostFlavor(string flavorName);
        Task<SqlDataReader> PostPerson(string FirstName, string LastName);
        Task<SqlDataReader> GetPerson(string firstName, string lastName);
        //Task<List<SqlDataReader>> GetAllFlavors();
        Task<SqlDataReader> GetPersonAndFlavors(int personId);

    }
}
