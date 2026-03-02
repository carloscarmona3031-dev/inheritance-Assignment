namespace geometricfig
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public double C
        {
            get { return _c; }
            set { _c = value; }
        }
        public double H
        {
            get { return _h; }
            set { _h = value; }
        }
        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C= c;
            H= h;
        }
        public override double GetArea()
        {
            return (this.B * _h) / 2;
        }
        public override double GetPerimeter()
        {
            return this.A + this.B + _c;
        }
        public void ValidateC()
        {
            if (this.C <= 0)
                throw new Exception("El lado c debe ser mayor a 0");
        }
        public void Validateh()
        {
            if (_h <= 0)
                throw new Exception("La altura h debe ser mayor a 0");
        }

    }
}
