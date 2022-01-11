using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SweetnSaltyModels;
using SweetnSaltyBusiness;


namespace SweetnSaltyBusiness
{
    public interface ISweetnSaltyBusinessClass
    {
        Task<Flavor> PostFlavor(string flavorName);
        Task<Person> PostPerson(string firstName, string lastName);
        Task<Person> GetPerson(string firstName, string lastName);
        //List<Flavor> GetAllFlavors();
        Task<Person> GetPersonAndFlavors(int personId);
        
    }
}
