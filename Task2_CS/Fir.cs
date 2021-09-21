namespace Task2_CS
{
    public class Fir:Conifer
    {
        private string _sort;
        public string Sort { get; set; }

        public Fir(string name, string species, string type, string sort) : base(name, species, type)
        {
            Sort = sort;
        }
        public override void GetOld()
        {
            Age += 1;
        }
    }
}