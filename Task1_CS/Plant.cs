using System;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Task1_CS
{
    public class Plant

    {
        //Константное поле
        public const string Kingdom="Plants";
        
        //Свойства
        private static string timeOfYear;
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != "fool")
                    _name = value;
                else
                {
                    _name = "invalid name!";
                }
                
            }
        }

        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0)
                    _age = value;
                else
                {
                    _age = 0;
                }
            }
        }

        public int Height { get; set; } //cm

        private string _lifeTime; //multi-year/one-year
        public string LifeTime {
            get
            {
                return _lifeTime;
            }
            set
            {
                if (value == "multi-year" | value == "one-year")
                {
                    _lifeTime = value;
                }
                else
                {
                    _lifeTime = "invalid value!";
                }
            } 
        }

         
        public bool Fruitly { get; set; }
        
        
        //Конструкторы
        public Plant(){}
        public Plant(string name, int age, int height, string lifeTime, bool fruitly)
        {
            this.Name= name;
            this.Age = age;
            this.Height = height;
            this.LifeTime = lifeTime;
            this.Fruitly = fruitly;
        }
        public Plant(bool fruitly,string lifeTime, string name, int age, int height)
        {
            this.Name= name;
            this.Age = age;
            this.Height = height;
            this.LifeTime = lifeTime;
            this.Fruitly = fruitly;
        }
        
        //Финализатор
        ~Plant()
        {
            Console.WriteLine("Finalizing");
        }
        
        //Методы
        public void GrowUp(int age)
        {
            Age += age;
            Height +=age * 5;
        }

        public void Watering()
        {
            Height += 5;
        }

        public void GrowUp(int age,int height)
        {
            if (age>1 & height>180)
            {
                _lifeTime = "multi-year";
            }
        }

        public void Harvest()
        {
            if (Fruitly == true & timeOfYear=="Spring")
            {
                Console.WriteLine("Harvest has grown!");
            }
            else
            {
               Console.WriteLine("This plant fruitless!"); 
            }
        }

        public static void ChangeTimeOfYear(string time)
        {
            timeOfYear = time;
        }

    }
}