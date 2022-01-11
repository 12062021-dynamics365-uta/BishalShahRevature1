using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using SweetnSaltyBusiness;
using SweetnSaltyModels;
using System.Collections.Generic;



namespace SweetnSaltyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class SweetnSaltyController : Controller
    {
        private readonly ISweetnSaltyBusinessClass _businessClass;

        //constructor
        public SweetnSaltyController(ISweetnSaltyBusinessClass ISweetnSaltyBusinessClass)
        {
            _businessClass = ISweetnSaltyBusinessClass;
        }


        [HttpPost]
        [Route("postaflavor/{flavorName}")]
        public async Task<ActionResult<Flavor>> PostFlavor(string flavorName)
        {
            Flavor yourflavor = await _businessClass.PostFlavor(flavorName);
            if (yourflavor != null)
            {
                return Created($"http://5001/sweetnsalty/postaflavor/{yourflavor.flavorName }", yourflavor);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("postaperson/{firstName}/{lastName}")]
        public async Task<ActionResult<Person>> PostPerson(string firstName, string lastName)
        {
            Person person = await _businessClass.PostPerson(firstName, lastName);
            if (person != null)
            {
                return Created($"http://5001/sweetnsalty/postaperson/{person.firstName}/{person.lastName}", person);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("getaperson/{fname}/{lname}")]
        public async Task<Person> GetPerson(string fname, string lname)
        {
            return null;
        }

        [HttpGet]
        [Route("getapersonandflavors/{id}")]
        public async Task<Person> GetPersonAndFlavors(int id)
        {
            return null;
        }

        [HttpGet]
        [Route("getlistofflavors")]
        public async Task<List<Flavor>> GetAllFlavors()
        {
            return null;
        }


    }
}

