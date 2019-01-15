using System;

namespace tscui.Pages.Phase
{
    /// <summary>
    /// The <see cref="Singleton1"/> Singleton class.
    /// </summary>
    public sealed class Singleton1
    {
        /// <summary>
        /// The Singleton instace. Declared 'static readonly' to enforce
        /// a single instance only and lazy initialisation.
        /// </summary>
        private static readonly Singleton1 instance = new Singleton1();

        /// <summary>
        /// Initializes a new instance of the <see cref="Singleton1"/> class.
        /// Declared private to enforce a single instance only.
        /// </summary>
        private Singleton1()
        {
        }

        /// <summary>
        /// Gets the Singleton1 Singleton Instance.
        /// </summary>
        public static Singleton1 Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
