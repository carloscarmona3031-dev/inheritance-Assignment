namespace geometricfig
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;

        public double D1 
        {
            get { return _d1; } 
            set { _d1 = value; } 
        }
        public double D2
        {
            get { return _d2; }
            set { _d2 = value; }
        }
        public Rhombus(string name, double a, double d1, double d2) : base(name,a)
        {
            D1 = d1;
            D2 = d2;
        }
        public override double GetArea()
        {
            return (_d1 * _d2) / 2;
        }
        public override double GetPerimeter()
        {
            return 4 * this.A ;
        }
    }
}
