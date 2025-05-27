namespace Commandos.Models
{
    public class CommandoFactory
    {
        List<Commando> commandoList = new List<Commando>();//list for Commando soldiers.
        string[] typeCommando = ["AirCommando", "SeaCommando", "Commando"];
        Random random = new Random();
        int CountCommandoCreate;
        int nameCode = 1;
        int numName = 1;
        

        //Constractor for CommandoFactory-class.
        public CommandoFactory(int countCommandoCreate)
        {
            CountCommandoCreate = countCommandoCreate;
        }

        //Create Commando instance and push to list. 
        public void CreateCommandoInstance()
        {
            string type = typeCommando[random.Next(0, 3)];
            Commando commando;
            switch (type)
            {
                case "AirCommando":
                    commando = new AirCommando($"soldier{numName}", nameCode);
                    numName++;
                    nameCode++;
                    commandoList.Add(commando);
                    break;
                case "SeaCommando":
                    commando = new SeaCommando($"soldier{numName}", nameCode);
                    numName++;
                    nameCode++;
                    commandoList.Add(commando);
                    break;
                default:
                    commando = new Commando($"soldier{numName}", nameCode);
                    numName++;
                    nameCode++;
                    commandoList.Add(commando);
                    break;
            }
        }

        //create all instanse that geting from argument.
        public void CreateCommandos()
        {
            
            for (int i = 0; i < CountCommandoCreate; i++)
            {
                CreateCommandoInstance();
            }
        }
    }
}