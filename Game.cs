namespace Commandos.Models
{
    public class Game
    {
        //Hear all instance of Commando-Weapons-Enemy.
        public void Initialization()
        {
            WeaponFactory weapons = new WeaponFactory();
            weapons.PlayCreating("M16", 2);
            weapons.PlayCreating("MK47", 2);
            foreach (var weapon in weapons.GetM16List())
            {
                weapon.PrintArgument();
            }
            

        }
        
    }
}