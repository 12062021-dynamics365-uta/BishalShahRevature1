using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SweetnSaltyModels;
using System.Data.SqlClient;

namespace SweetnSaltyBusiness
{
    public class Mapper : IMapper
    {
        public Flavor EntityToFlavor(SqlDataReader sdr)
        {
            return new Flavor()
            {
                
                flavorID = sdr.GetInt32(0),

                flavorName = sdr[1].ToString(),
            };
        }

        public Person EntityToPerson(SqlDataReader sdr)
        {
            return new Person()
            {

                playerID = sdr.GetInt32(0),
                firstName = sdr[1].ToString(),
                lastName = sdr[2].ToString(),
            };
        }
        /*
        public Person EntityToPersonFlavor(SqlDataReader sdr);
        {
            
        }
        public Flavor EntityToListOfFlavors(SqlDataReader sdr)
        { }
        */

    }
}
