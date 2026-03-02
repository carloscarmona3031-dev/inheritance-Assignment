namespace geometricfig
{
    public class Parallelogram : Rectangle
    {
        private double _h;
        private double H 
        {
            get {return _h;}
            set { _h = value;}
        }
        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }
        public override double GetArea()
        {
            return this.B * _h;
        }
        public override double GetPerimeter()
        {
            return 2 * (this.A + this.B);
        }
        private Boolean ValidateH()
        {
            return true;
        }
    }
}
