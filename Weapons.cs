using System.Reflection.Metadata.Ecma335;
using Commandos.Models;

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

        //Shoots a gun bullet and subtracts from the total number of bullets.
        public void Shoot()
        {
            if (NumBullets > 0)
            {
                NumBullets--;
                Console.WriteLine("Shot");
            }
            else
            {
                Console.WriteLine("Click-click - There are no bullets in stock");
            }    
        }
    }
}