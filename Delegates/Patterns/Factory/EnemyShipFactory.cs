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
                    ret = UFOEnemyShip.Create();
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

    public interface IArmed
    {
        public string Description { get; set; }
    }

    public class ArmsDisabled : IArmed
    {
        public string Description { get; set; } = "Arms disabled";
    } 
    
    public class ArmsEnabled : IArmed
    {
        public string Description { get; set; } = "Arms enabled";
    }

    public abstract class Ship
    {
        public string Name { get; set; }
        protected IArmed ArmedStatus { get; set; }
    }

    public abstract class EnemyShip : Ship
    {
        
    }

    internal class UFOEnemyShip : EnemyShip
    {
        private UFOEnemyShip()
        {
            Name = "UFO Enemy Ship";
            ArmedStatus = new ArmsDisabled();
        }

        public static UFOEnemyShip Create()
        {
            return new();
        }
    }
    
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