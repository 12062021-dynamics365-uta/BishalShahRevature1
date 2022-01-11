using System;
using System.Threading.Tasks;
using SweetnSaltyDbAccess;
using SweetnSaltyModels;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace SweetnSaltyBusiness
{
    public class SweetnSaltyBusinessClass : ISweetnSaltyBusinessClass
    {
        private readonly ISweetnSaltyDbAccessClass _dbaccess;
        private readonly IMapper _mapper;
        public SweetnSaltyBusinessClass(ISweetnSaltyDbAccessClass Dbaccess, IMapper Mapper)//you need a reference to the DbAccess Layer 
        {
            _dbaccess = Dbaccess;
            _mapper = Mapper;
        }

        public async Task<Flavor> PostFlavor(string flavorName)
        {
            SqlDataReader sdr = await _dbaccess.PostFlavor(flavorName);
            if (sdr.Read())
            {
                Flavor flav = _mapper.EntityToFlavor(sdr);

                return flav;
            }
            else
            {
                return null;
            }

        }

         public async Task<Person> PostPerson(string firstName, string lastName)
         {
            SqlDataReader sdr = await _dbaccess.PostPerson(firstName, lastName);
            if (sdr.Read())
            {
                Person person = _mapper.EntityToPerson(sdr);

                return person;
            }
            else
            {
                return null;
            }
            
         }
        public async Task<Person> GetPerson(string firstName, string lastName)
        {
            SqlDataReader sdr = await _dbaccess.GetPerson(firstName, lastName);
            if (sdr.Read())
            {
                Person person = _mapper.EntityToPerson(sdr);

                return person;
            }
            else
            {
                return null;
            }
        }
        /*
        public async Task<List<Flavor>> GetAllFlavors()
        {
            //SqlDataReader sdr = await _dbaccess.GetAllFlavors();
            //return output as a list
            return null;
        }
        */
        public async Task<Person> GetPersonAndFlavors(int personId)
        {
            SqlDataReader sdr = await _dbaccess.GetPersonAndFlavors(personId);
            if (sdr.Read())
            {
                Person person = _mapper.EntityToPerson(sdr);
                Flavor flavor = _mapper.EntityToFlavor(sdr);
                return person;
            }
            else
            {
                return null;
            }
        }
    }
}
