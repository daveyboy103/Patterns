using System;

namespace Delegates.Patterns.Factory
{
    public class EnemyShipFactory
    {
        public Ship Create(string shipType)
        {
            Ship ret;
            
            switch (shipType.ToUpper())
            {
                case "UFO":
                    ret = UfoEnemyShip.Create();
                    break;
                case "ROCKET":
                    ret = RocketEnemyShip.Create();
                    break;
                default:
                    throw new NotImplementedException($"Enemy ship of type [{shipType}] not implemented yet!");
            }

            return ret;
        }
    }
}