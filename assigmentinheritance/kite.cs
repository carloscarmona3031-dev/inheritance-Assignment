namespace geometricfig
{
    public class Kite : Rhombus
    {
        private double _b;

        private double B
        {
          get {return _b; }
            set { _b = value; }
        }
        public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
        {
            B = b;
        }
        public override double GetArea()
        {
            return (this.D1 * this.D2) / 2;
        }
        public override double GetPerimeter()
        {
            return 2 * (this.A + this.B);
        }
    }
}
