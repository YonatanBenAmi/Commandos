namespace Commandos.Models
{
    public class SeaCommando : Commado
    {
        public SeaCommando(string name, int codeName) : base(name, codeName) { }

        public void ability()
        {
            Console.WriteLine("The Marine Commando has insane swimming abilities.");
        }

        public void Attack()
        {
            Status = "attacking";
            Console.WriteLine($"Naval commando soldier id: {SayCodeName()} attacks!");
        }
    }
}