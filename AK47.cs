namespace Commandos.Models
{
    public class AK47 : Weapon, IShootable
    {
        public int NumBullets = 29;

        //Constractor for Weapon-class.
        public AK47() : base("AK47", "KALASHNIKOV"){}

        //Shoots a gun bullet and subtracts from the total number of bullets.
        public void Shoot()
        {
            if (NumBullets > 0)
            {
                NumBullets--;
                Console.WriteLine("Shot");
            }
            else
            {
                Console.WriteLine("Click-click - There are no bullets in stock");
            }
        }
        
        //Print argument
        public void PrintArgument()
        {
            Console.WriteLine($"Name - {Name} , Producer - {Producer} , NumBullets - {NumBullets}");
        }
    }
}