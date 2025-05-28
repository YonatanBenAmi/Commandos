namespace Commandos.Models
{
    public class Stone : IBreakable
    {
        public string Name;
        public double weight;
        public string Color;
        public bool status;
        public int hitsUntilBreak;
        public int currentHitCount = 0; 

        

    }
}