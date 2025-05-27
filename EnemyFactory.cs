namespace Commandos.Models
{
    public class EnemyFactory
    {
        List<Enemy> enemyList = new List<Enemy>();
        int CountCommandoCreate;
        int numEnemy = 1;

        //Constractor for EnemyFactory-class.
        public EnemyFactory(int countCommandoCreate)
        {
            CountCommandoCreate = countCommandoCreate;
        }

        //Create Enemy instance and push to list. 
        public void CreateEnemyInstance()
        {
            Enemy enemy = new Enemy($"Enemy{numEnemy}");
            enemyList.Add(enemy);
        }

        //create all instanse that geting from argument.
        public void CreateEnemy()
        {
            for (int i = 0; i < CountCommandoCreate; i++)
            {
                CreateEnemyInstance();
            }
        }
    }
}