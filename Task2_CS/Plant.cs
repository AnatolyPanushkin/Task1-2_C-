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
        protected string Age { get; set; }
        protected static string timeOfyear;

        public Plant(string name)
        {
            this.Name = name;
        }

        protected void ChangeTimeOfYear(string time)
        {
            timeOfyear = time;
        }
    }
}