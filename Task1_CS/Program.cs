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
            Console.WriteLine("Название:{0}, Возраст:{1}, Высота:{2}, Многолетний/Однолетний:{3}, Плодовое/Не плодовое:{4}", plant.Name,
                plant.Age,plant.Height,plant.LifeTime,plant.Fruitly);
        }
    }
}