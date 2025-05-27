namespace Commandos.Models
{
    public class Commado
    {
        //Fields.
        private string Name;
        public int CodeName;
        public string[] Tools;
        public string Status;

        //Constractor for Commando-class.
        public Commado(string name, int codeName)
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

        //Change status and print that soldier hiding.
        public void Hide()
        {
            Status = "hide";
            Console.WriteLine("The soldier is hiding.");
        }

        //Change status and print codeName soldier that attacking.
        public void Attack()
        {
            Status = "attacking";
            Console.WriteLine($"A commando with a codename {CodeName} is attacking");
        }
        
    }
}