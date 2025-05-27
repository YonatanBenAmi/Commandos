namespace Commandos.Models
{
    public class Commando
    {
        //Fields.
        private string Name;
        private int CodeName;
        public string[] Tools;
        public string Status;

        //Constractor for Commando-class.
        public Commando(string name, int codeName)
        {
            Name = name;
            CodeName = codeName;
            Tools = ["hammer", "Chisel", "rope", "bag", "canteen"];
            Status = "unknown";
        }

        //Change status and print that soldier walking.
        public void Walk()
        {
            Status = "walk";
            Console.WriteLine("The soldier is walking.");
        }

        //Get name.
        private string SayName()
        {
            return Name;
        }

        //Get code name.
        public int SayCodeName()
        {
            return CodeName;
        }

        //Getting the name with access permission filtering.
        public string AccessFilterName(string commanderRank)
        {
            string UpperCaceRank = commanderRank.ToUpper();
            switch (UpperCaceRank)
            {
                case "GENERAL":
                    return SayName();
                case "COLONEL":
                    return SayCodeName().ToString();
                default:
                    return "The information is classified.";
            }
        }

        //Change status and print that soldier hiding.
        public void Hide()
        {
            Status = "hide";
            Console.WriteLine("The soldier is hiding.");
        }

        //Change status and print codeName soldier that attacking.
        public virtual void Attack()
        {
            Status = "attacking";
            Console.WriteLine($"A commando with a codename {CodeName} is attacking");
        }
        
    }
}