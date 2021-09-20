using System;

namespace Task2_CS
{
    public class Conifer:Tree

    {
        private string _type;

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public Conifer(string name, string species, string type):base(name,species)
        {
            Type = type;
        }

        public void PeniconeFall()
        {
            Console.WriteLine("penicone is grown!");
        }

        public override void GrowUp()
        {
            Height += 10;
        }
    }
}