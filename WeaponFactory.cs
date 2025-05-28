namespace Commandos.Models
{
    public class WeaponFactory
    {
        List<M16> M16List = new List<M16>();
        List<AK47> AK47List = new List<AK47>();

        //get number of instanse.
        public void PlayCreating(string type, int count)
        {
            CreateWeapons(type, count);
        }


        //Create Weapon instance and push to list. 
        public void CreateWeaponInstance(string type)
        {
            switch (type)
            {
                case "M16":
                    M16List.Add(new M16());
                    break;
                case "AK47":
                    AK47List.Add(new AK47());
                    break;
                default:
                    Console.WriteLine("Worng");
                    break;
            }
        }

        //create all instanse that geting from argument.
        public void CreateWeapons(string type, int CountCommandoCreate)
        {
            for (int i = 0; i < CountCommandoCreate; i++)
            {
                CreateWeaponInstance(type);
            }
        }

        //Return list of M16 weapons.
        public List<M16> GetM16List()
        {
            return M16List;
        }
        
        //Return list of MK47 weapons.
        public List<AK47> GetAK47List()
        {
            return AK47List;
        } 
    }
}