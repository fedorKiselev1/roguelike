using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Weapon
    {
        public Weapon(string name, float damage, float durability) 
        { 
            Name = name;
            Damage = damage;
            Durability = durability;
        }
        public string Name { get; set; }
        public float Damage { get; set; }
        public float Durability { get; set; }
    }
}
