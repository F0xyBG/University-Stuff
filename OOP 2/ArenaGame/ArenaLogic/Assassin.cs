namespace ArenaLogic;

public class Assassin : Hero
{
    const int CriticalChance = 30;
    const int CriticalModifier = 3;
    const int FatalChance = 5;
    const int FatalDamage = 9999;

    public Assassin(string name, int strength, int health) : 
        base(name, strength, health)
    {
        
    }

    public override int Attack()
    {
        int initial = base.Attack();
        if (ThrowDice(CriticalChance))
        {
            initial = initial * CriticalModifier;
        }
        if (ThrowDice(FatalChance))
        {
            initial = FatalDamage;
        }
        return initial;
     }
}
