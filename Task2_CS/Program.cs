using System;

namespace Task2_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            var blueSpruce = new BlueSpruce("Tree", "Conifer", "Fir", "BlueSpruse", 100);
            blueSpruce.GetOld();
            blueSpruce.GrowUp();
            Console.WriteLine(blueSpruce.Height);
        }
    }
}