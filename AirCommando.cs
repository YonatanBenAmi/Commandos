namespace Commandos.Models
{
    public class AirCommando : Commado
    {
        //Constractor for AirCommando-class
        public AirCommando(string name, int codeName) : base(name, codeName) { }

        //Prints the capability of the air commando unit
        public void ability()
        {
            Console.WriteLine("The Air Commando has impressive parachuting capabilities.");
        }

        //Change status and print codeName soldier that attacking.
        public override void Attack()
        {
            Status = "attacking";
            Console.WriteLine($"Air commando soldier id: {SayCodeName()} attacks!");
        }
    }
}