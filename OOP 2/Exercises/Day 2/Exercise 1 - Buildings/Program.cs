namespace Day_2;

class Program
{
    static void Main(string[] args)
    {
        //write code to make an array of buildings and to cwl the total area
        Building[] buildings = new Building[3];
        buildings[0] = new Building(100, 10, "Red");
        buildings[1] = new Building(200, 20, "Yellow");
        buildings[2] = new Building(300, 30, "Opal");

        double totalArea = 0;
        foreach (Building building in buildings)
        {
            totalArea += building.Area;
        }

        Console.WriteLine($"Total area of all buildings in array: {totalArea}");
    }
}
