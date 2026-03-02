namespace geometricfig
{
    public class Kite : Rhombus
    {
        private double _b;

        public double B
        {
          get {return _b; }
            set {
                ValidateB(value);
                _b = value;
                }
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
        private void ValidateB(double value)
        {
            if (value <= 0)
                throw new ArgumentException($"lado B no puede ser {value}.");
        }
    }
}
