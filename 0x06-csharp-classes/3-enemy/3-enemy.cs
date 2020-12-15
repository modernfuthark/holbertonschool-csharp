using System;

namespace Enemies
{
    /// <summary>
    /// Public class for a zombie
    /// </summary>
    class Zombie
    {
        /// <summary>
        /// The zombie's health
        /// </summary>
        private int health;

        /// <summary>
        /// Class constructor for <see cref="Zombie"/>
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>
        /// Class constructor for <see cref="Zombie"/> with a health value
        /// </summary>
        public Zombie(int value)
        {
            if (value >= 0)
                this.health = value;
            else
                throw new ArgumentException("Health must be greater than or equal to 0");
        }

        /// <summary>
        /// Getter for the health field
        /// </summary>
        public int GetHealth()
        {
            return this.health;
        }
    }
}
