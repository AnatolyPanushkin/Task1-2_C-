using System;

namespace Task1_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Plant plant = new Plant("Doob",5,154,"one-year",true);
            Plant.ChangeTimeOfYear("Winter");
            plant.GrowUp(5);
            plant.Watering();
            plant.GrowUp(5,201);
            plant.Harvest();
            Console.WriteLine(plant.Name);
            Console.WriteLine(plant.Age);
            Console.WriteLine(plant.Height);
            Console.WriteLine(plant?.LifeTime);
        }
    }
}