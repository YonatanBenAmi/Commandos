namespace Commandos.Models
{
    public class SeaCommando : Commando
    {
        //Constractor for SeaCommando-class.
        public SeaCommando(string name, int codeName) : base(name, codeName) { }

        //Prints the capability of the Marine Commando unit.
        public void ability()
        {
            Console.WriteLine("The Marine Commando has insane swimming abilities.");
        }

        //Change status and print codeName soldier that attacking.
        public override void Attack()
        {
            Status = "attacking";
            Console.WriteLine($"Naval commando soldier id: {SayCodeName()} attacks!");
        }
    }
}