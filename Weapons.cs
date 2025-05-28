using System.Reflection.Metadata.Ecma335;
using Commandos.Models;

namespace Commandos.Models
{
    public class Weapon
    {
        public string Name;
        public string Producer;

        //Constractor for Weapon-class.
        public Weapon(string name, string producer)
        {
            Name = name;
            Producer = producer;
        }  
    }
}