namespace geometricfig
{
    public abstract class GeometricFigure
    {
        public string? Name { get; set; }

        protected GeometricFigure(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
        public override string ToString()
        {
            return string.Format(
                 "{0,-15} => Area.....: {1,12:F5}    Perimeter: {2,10:F5}",
                 Name,
                 GetArea(),
                 GetPerimeter()
            );
        }
    }
}


