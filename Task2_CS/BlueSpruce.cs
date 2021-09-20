namespace Task2_CS
{
    public class BlueSpruce:Fir
    {
        private int Diametr { get; set; }

        public BlueSpruce(string name, string species, string type, string sort, int diametr) : base(name, species,
            type, sort)
        {
            Diametr = diametr;
        }

        public override void GrowUp()
        {
            Height += 7;
        }

        public override void GetOld()
        {
            Age +=2;
        }
    }
}