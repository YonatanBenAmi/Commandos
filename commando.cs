namespace Commandos.Models
{
    public class Commado
    {
        public string Name;
        public int CodeName;
        public string[] Tools;
        public string Status;


        public Commado(string name, int codeName, string[] tools)
        {
            Name = name;
            CodeName = codeName;
            Tools = tools;
            Status = "unknown";
        }

        public void Walk()
        {
            Status = "walk";
            Console.WriteLine("The soldier is walking.");
        }

        public void Hide()
        {
            Status = "hide";
            Console.WriteLine("The soldier is hiding.");
        }
        
    }
}