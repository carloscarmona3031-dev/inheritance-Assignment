namespace geometricfig
{
    public class Trapeze : Triangle
    {
        private double _d;
        private double D
        {
            get {  return _d; }
            set { _d = value; }
        }

        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name,a,b,c,h)
        {
            D = d;
        }
        public override double GetArea()
        {
            return ((this.B + _d) * this.H)/2;
        }
        public override double GetPerimeter()
        {
            return this.A + this.B + this.C + _d;
        }
        private void ValidateD()
        {
            if (_d < 0)
                throw new Exception("El lado d debe ser mayor a 0");
        }

    }
}
