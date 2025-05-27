namespace Commandos.Models
{
    public class WeaponFactory
    {
        List<Weapon> weaponList = new List<Weapon>();

        //Create Weapon instance and push to list. 
        public void CreateWeaponInstance(string name, string producer, int numBillets)
        {
            Weapon weapon = new Weapon(name, producer, numBillets);
            weaponList.Add(weapon);
        }
    }
}