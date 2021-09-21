namespace Task2_CS
{
    public abstract class Plant
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value!="fool")
                {
                    _name = value;
                }
            }
        }
        protected int Age { get; set; }
        protected static string timeOfyear;

        public Plant(string name)
        {
            this.Name = name;
        }

        public abstract void GetOld();
        public abstract void GrowUp();
        protected void ChangeTimeOfYear(string time)
        {
            timeOfyear = time;
        }
    }
}