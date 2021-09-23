namespace Delegates.Patterns.Factory
{
    internal class UfoEnemyShip : EnemyShip
    {
        private UfoEnemyShip()
        {
            Name = "UFO Enemy Ship";
            ArmedStatus = new ArmsDisabled();
        }

        public static UfoEnemyShip Create()
        {
            return new();
        }
    }
}