namespace ArenaLogic;

public class Arena
{
    public Hero HeroA { get; private set; }
    public Hero HeroB { get; private set; }

    public ArenaBattleEvent OnBattleTurn { get; set; }

    public Arena(Hero a, Hero b)
    {
        HeroA = a; HeroB = b;
    }

    public Hero Battle()
    {
        Hero winner;
        Hero attacker, defender;
        if (Random.Shared.Next (0, 2) < 1)
        {
            attacker = HeroA;
            defender = HeroB;
        } 
        else
        {
            attacker = HeroB;
            defender = HeroA;
        }
        while (true)
        {
            int damage = attacker.Attack();
            int damageTaken = defender.Defend(damage);
            if (OnBattleTurn is not null)
            {
                var args = new ArenaEventArgs()
                {
                    Attacker = attacker,
                    Defender = defender,
                    Damage = damage,
                    DamageTaken = damageTaken,
                };
                OnBattleTurn(args);
            }
            if (!defender.IsAlive)
            {
                winner = attacker;
                break;
            }
            Hero temp = attacker;
            attacker = defender;
            defender = temp;
        }
        return winner;
    }
}
