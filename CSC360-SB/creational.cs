// Referenced https://refactoring.guru/design-patterns/singleton/csharp/example, thank you very much!

using System;

namespace CSC360_SB
{
    public sealed class Singleton
    {
        // Static instance
        private static Singleton instance;

        // Private constructor
        private Singleton() { }

        // Used to safeguard/synchronize threads in a multi-threaded environment
        private static readonly object _lock = new object();

        // Get access to static instance
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null) instance = new Singleton();
                }
            }

            return instance;
        }
    }
}
