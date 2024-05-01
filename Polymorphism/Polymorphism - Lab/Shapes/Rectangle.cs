using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double _height;
        private double _width;
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height 
        {
            get => _height;
            private set { _height = value; }

        }
        public double Width
        {
            get => _width;
            private set { _width = value; }

        }

        public override double CalculateArea()
        {
            return _height * _width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * _height + 2 * _width;
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
