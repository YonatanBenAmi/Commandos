using Commandos.Models;
namespace Commandos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Commado[] soldiersArr =
            {
                new Commado("Yonatan", 1111),
                new SeaCommando("Moshe", 2222),
                new AirCommando("Shay", 3333),
            };

            foreach (var soldier in soldiersArr)
            {
                soldier.Attack();
            }
        }
    }
}