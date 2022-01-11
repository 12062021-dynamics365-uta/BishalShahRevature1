using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SweetnSaltyModels;

namespace SweetnSaltyBusiness
{
    
    public interface IMapper
    {
        Flavor EntityToFlavor(SqlDataReader sdr);
        Person EntityToPerson(SqlDataReader sdr);
        //Person EntityToPersonFlavor(SqlDataReader sdr);
        //Flavor EntityToListOfFlavors(SqlDataReader sdr);

    }
    
}
