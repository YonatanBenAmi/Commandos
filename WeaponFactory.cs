namespace Commandos.Models
{
    public class WeaponFactory
    {
        List<Weapon> weaponList = new List<Weapon>();
        Random random = new Random();
        int CountCommandoCreate;
        string[] weaponType = ["M16", "Karlo"];
        string[] producer = ["USA", "Personaly"];


        //Constractor for WeaponFactory-class.
        public WeaponFactory(int countCommandoCreate)
        {
            CountCommandoCreate = countCommandoCreate;
        }

        //Create Weapon instance and push to list. 
        public void CreateWeaponInstance()
        {
            Weapon weapon = new Weapon(weaponType[random.Next(0, 2)], producer[random.Next(0, 2)], random.Next(0, 100));
            weaponList.Add(weapon);
        }
        
        //create all instanse that geting from argument.
        public void CreateWeapons()
        {
            for (int i = 0; i < CountCommandoCreate; i++)
            {
                CreateWeaponInstance();
            }
        }
    }
}