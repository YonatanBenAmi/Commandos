using Commandos.Models;
namespace Commandos
{
    public class Program
    {
        static void Main(string[] args)
        {
            //testing 
            Commado commado1 = new Commado("Yonatan", 123);
            commado1.Attack();
            Console.WriteLine($" - commado1.CodeName - {commado1.Status}");
            Weapon weapon1 = new Weapon("Mag", "USA", 50);
            weapon1.Shoot();
            Console.WriteLine($"{weapon1.Name} - {weapon1.Producer} - {weapon1.NumBullets}");
        }
    }
}