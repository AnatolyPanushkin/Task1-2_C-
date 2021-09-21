using System;

namespace Task2_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Fir blueSpruce = new BlueSpruce("Tree", "Conifer", "Fir", "BlueSpruse", 100,0);
            blueSpruce.GetOld();
            blueSpruce.GrowUp();
            Console.WriteLine(blueSpruce.Height);
        }
    }
}