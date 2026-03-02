namespace geometricfig
{
    public class Circle : GeometricFigure
    {
        private double _r;
        public double R { 
            get { return _r; } 
            set { _r = value; } 
        }
        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_r, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * _r;
        }

        public void ValidateRadius()
        {
            if (_r <= 0)
                throw new ArgumentException("El radio debe ser mayor a 0");
        }
    }

}
