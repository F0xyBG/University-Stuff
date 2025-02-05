namespace ArenaLogic;

public class ArenaEventArgs
{
    public Hero Attacker { get; set; }
    public int Damage { get; set; }
    public Hero Defender { get; set; }

    public int DamageTaken { get; set; }
}

public delegate void ArenaBattleEvent(ArenaEventArgs e);
