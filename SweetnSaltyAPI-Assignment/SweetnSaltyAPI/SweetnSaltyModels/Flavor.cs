
namespace SweetnSaltyModels
{
    public class Flavor
    {
        public int flavorID { get; set; }
        public string flavorName { get; set; }


        public Flavor(string flavorName)
        {
            this.flavorName = flavorName;
        }

        public Flavor() { }
    }

}
