using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Enemy
    {
        public Enemy(string name, float health, float maxHealth, Weapon weapon) 
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
            Weapon = weapon;
        }
        public string Name { get; set; }
        public float Health { get; set; }
        public float MaxHealth { get; set; }
        public Weapon Weapon { get; set; }
    }
}
