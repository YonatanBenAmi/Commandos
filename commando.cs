namespace Commandos.Models
{
    public class Commado
    {
        //Fields.
        public string Name;
        public int CodeName;
        public string[] Tools;
        public string Status;

        //Constractor for Commando-class.
        public Commado(string name, int codeName, string[] tools)
        {
            Name = name;
            CodeName = codeName;
            Tools = tools;
            Status = "unknown";
        }

        //Change status and print that soldier walking.
        public void Walk()
        {
            Status = "walk";
            Console.WriteLine("The soldier is walking.");
        }

        //Change status and print that soldier hiding.
        public void Hide()
        {
            Status = "hide";
            Console.WriteLine("The soldier is hiding.");
        }

        //Print codeName soldier that attacking.
        public void Attack()
        {
            Console.WriteLine($"A commando with a codename {CodeName} is attacking");
        }
        
    }
}