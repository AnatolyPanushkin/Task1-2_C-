namespace Task2_CS
{
    public class Tree : Plant
    {
        private string _species;

        public string Species
        {
            get
            {
                return _species;
            }
            set
            {
                if (value!="fool")
                {
                    _species = value;
                }
            }
        }

        protected int _height;

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value>=0)
                {
                    _height = value;
                }
            }
        }

        public Tree(string name, string species) : base(name)
        {
            Species = species;
        }

        public override void GetOld()
        {
            Age += 1;
        }


        public override void GrowUp()
        {
            Height += 10;
        }
    }
}