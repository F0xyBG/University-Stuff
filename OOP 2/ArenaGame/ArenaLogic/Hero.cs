namespace ArenaLogic
{
    public class Hero
    {
        public string Name { get; private set; }

        public Hero(string name, int strength, int health)
        {
            Name = name;
            Strength = strength;
            Health = health;
        }

        public int Strength { get; private set; }
        public int Health { get; private set; }

        public virtual int Attack()
        {
            int coef = Random.Shared.Next(80, 121);
            return (Strength * coef) / 100;
        }

        public virtual int Defend(int incomingDamage)
        {
            if (incomingDamage < 0) { incomingDamage = 0; }
            Health = Health - incomingDamage;
            return incomingDamage;
        }

        public bool IsAlive { get { return Health > 0; } }

        protected bool ThrowDice(int chance)
        {
            return Random.Shared.Next(1, 101) <= chance;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
