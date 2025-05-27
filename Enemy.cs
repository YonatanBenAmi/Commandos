using System.Reflection.Metadata;

namespace Commandos.Models
{
    public class Enemy
    {
        public string Name;
        public int Life;
        public bool IsAlive;
        public string Shout;

        //Constractor for Enemy-class.
        public Enemy(string name)
        {
            Name = name;
            Life = 100;
            IsAlive = true;
            Shout = "I am an enemy.";
        }
    }
}