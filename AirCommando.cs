namespace Commandos.Models
{
    public class AirCommando : Commado
    {
        public AirCommando(string name, int codeName) : base(name, codeName) { }

        public void ability()
        {
            Console.WriteLine("The Air Commando has impressive parachuting capabilities.");
        }
    }
}