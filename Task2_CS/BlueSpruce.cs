using System;

namespace Task2_CS
{
    public class BlueSpruce:Fir
    {
        private int Diametr { get; }

        public BlueSpruce(string name, string species, string type, string sort, int diametr,int age) : base(name, species,
            type, sort)
        {
            Diametr = diametr;
            Age = age;
        }

        public override void GrowUp()
        {
            Height += 7;
        }

        public override void GetOld()
        {
            Age +=2;
            Console.WriteLine(Age);
        }
    }
}