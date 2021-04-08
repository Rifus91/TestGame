using System;
using System.Collections.Generic;
using System.Text;

namespace TestGame
{
    public class GameContext
    {
        public GameContext(int maxHealth)
        {
            MaxHealth = maxHealth;
            Health = MaxHealth;
        }

        public int MaxHealth { get; }
        public int Health { get; private set; }

        public void SetHealth(int health)
        {
            if (health < 0)
            {
                Health = 0;
            } else if (health > MaxHealth)
            {
                Health = MaxHealth;
            } else
            {
                Health = health;
            }


        }
    }
}
