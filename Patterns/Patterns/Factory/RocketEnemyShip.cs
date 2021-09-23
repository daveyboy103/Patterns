namespace Delegates.Patterns.Factory
{
    internal class RocketEnemyShip: EnemyShip{
        private RocketEnemyShip()
        {
            Name = "Rocket Enemy Ship";
            ArmedStatus = new ArmsEnabled();
        }
        
        public static RocketEnemyShip Create()
        {
            return new();
        }
    }
}