using System;

namespace SweetnSaltyModels
{
    public class Person
    {
        public int playerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }


         public Person() { }
         public Person(string firstName, string lastName)
         {
            this.firstName = firstName;
            this.lastName = lastName;
         }
    }
}
