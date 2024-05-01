using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get => _radius;
            private set { _radius = value; }
           
        }
       

        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(_radius,2), 2);

        }

        public override double CalculatePerimeter()
        {
            return Math.Round(2 * Math.PI * _radius, 2);

        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Draw());
            sb.Append(GetType().Name);
            return sb.ToString().TrimEnd();
        }
    }
}
