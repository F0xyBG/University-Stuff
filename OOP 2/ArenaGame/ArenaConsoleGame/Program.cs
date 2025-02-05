using ArenaConsoleGame;
using ArenaLogic;

FileStatistics fileStatistics = new FileStatistics(@"D:\temp\arenastats.txt");

Dictionary<string, int> victories = new Dictionary<string, int>();

for (int i = 0; i < 1; i++) //Play with the counts to see how balanced it is.
{
    Knight knight = new Knight("Sir John", 100, 1500);
    Assassin assassin = new Assassin("Stinking Joe", 150, 1000);

    Arena arena = new Arena(knight, assassin);
    arena.OnBattleTurn = e =>
    {
        Console.WriteLine($"{e.Attacker} attacks for {e.Damage}, " +
            $"but {e.Defender} takes {e.DamageTaken} damage.");
    };

    var winner = arena.Battle();

    fileStatistics.UpdateStatistic(winner.GetType().Name);

    if (!victories.ContainsKey(winner.GetType().Name))
    {
        victories.Add(winner.GetType().Name, 1);
    }
    else
    {
        victories[winner.GetType().Name] += 1;
    }


    //Console.WriteLine($"The winner is {winner.GetType().Name} {winner.Name}");
}

foreach (var item in victories)
{
    Console.WriteLine($"{item.Key} has {item.Value} wins");
}

Console.ReadLine();