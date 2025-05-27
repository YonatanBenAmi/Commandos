namespace Commandos.Models
{
    public class Commado
    {
        public string Name;
        public int CodeName;
        public string[] Tools;
        public string[] Status;


        public Commado(string name, int codeName, string[] tools, string[] status)
        {
            Name = name;
            CodeName = codeName;
            Tools = tools;
            Status = status;
        }
        
    }
}