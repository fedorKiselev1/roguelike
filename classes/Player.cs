namespace classes
{
    public class Player
    {
        public Player(string name, float health, float maxHealth, Medkit medkit, Weapon weapon) 
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
            Medkit = medkit;
            Weapon = weapon;
            Score = 0;
        }
        public string Name { get; set; }
        public float Health { get; set; }
        public float MaxHealth { get; set; }
        public Medkit Medkit { get; set; }
        public Weapon Weapon { get; set; }
        public double Score { get; set; }
    }
}