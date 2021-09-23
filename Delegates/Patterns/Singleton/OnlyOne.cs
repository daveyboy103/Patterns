using System;

namespace Delegates.Patterns.Singleton
{
    public class OnlyOne
    {
        private static OnlyOne _instance;
        private static readonly object Locker = new();
        
        private OnlyOne()
        {
            Born =$"{DateTime.UtcNow.ToLongTimeString()} on {DateTime.UtcNow.ToLongDateString()}" ;
        }
        
        public string Born { get; }

        public static OnlyOne Instance
        {
            get
            {
                lock (Locker)
                {
                    return _instance ??= new OnlyOne();
                }
            }
        }
    }
}