namespace Commandos.Models
{
    public class EnemyFactory
    {
        List<Enemy> enemyList = new List<Enemy>();

        //Create Enemy instance and push to list. 
        public void CreateEnemyInstance(string name)
        {
            Enemy enemy = new Enemy(name);
            enemyList.Add(enemy);
        }
    }
}