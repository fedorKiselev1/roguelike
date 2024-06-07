using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Medkit
    {
        public Medkit(string name, float healing) 
        {
            Name = name;
            Healing = healing;
        }
        public string Name { get; set; }
        public float Healing { get; set; }
    }
}
