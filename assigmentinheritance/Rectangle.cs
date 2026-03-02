using geometricfig;

namespace geometricfig
{
    public class Rectangle : Square
    {
        private double _b;
        public double B
        {
            get
            {
                return _b;
            }
            set
            {
                _b = value;
            }
        }
        public Rectangle(string name, double a, double b) : base(name,a)
        {
            B= b;
        }
        public override double GetArea()
        {
            return this.A * _b;
        }
        public override double GetPerimeter()
        {
            return 2 *(this.A + _b);
        }
        private Boolean ValidateB()
        {
            return true;
        }
    }
}
