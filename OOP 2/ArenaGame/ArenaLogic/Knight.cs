namespace ArenaLogic;

public class Knight : Hero
{
    private const int BlockChance = 30;

    public int Armor { get; private set; }

    public Knight() : this("Sir John", strength: 100, health: 1000)
    {
        
    }

    public Knight(string name, int strength, int health) : 
        base(name, strength, health)
    {
        Armor = 20;
    }

    public override int Defend(int incomingDamage)
    {
        incomingDamage = incomingDamage - Armor;
        if (ThrowDice(BlockChance)) incomingDamage = 0;
        return base.Defend(incomingDamage);
    }
}
