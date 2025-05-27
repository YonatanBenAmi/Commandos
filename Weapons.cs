using System.Reflection.Metadata.Ecma335;

namespace Commandos.Models
{
    public class Weapon
    {
        public string Name;
        public string Producer;
        public int NumBullets;

        //Constractor for Weapon-class.
        public Weapon(string name, string producer, int numBillets)
        {
            Name = name;
            Producer = producer;
            NumBullets = numBillets;
        }
    }
}