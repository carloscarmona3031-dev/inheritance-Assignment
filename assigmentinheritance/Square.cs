namespace geometricfig
{
    public class Square : GeometricFigure
    {
        private double _a;

        public double A
        {
            get { return _a; }
            set { _a = value; }
        }

        public Square(string name, double a) 
        {
            Name = name;
            this.A = a;
        }

        public override double GetArea()
        {
            return _a * _a;
        }

        public override double GetPerimeter()
        {
            return 4 * _a;
        }
        private Boolean ValidateA()
        {
            return true;
        }

    }
}
