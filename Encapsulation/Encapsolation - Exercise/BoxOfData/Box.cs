namespace ClassBoxData
{
    public class Box
    {
        private readonly double length;
        private readonly double width;
        private readonly double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Height
        {
            get { return height; }
            init
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }
                 height = value;
            }
        }
        public double Width
        {
            get { return width; }
            init
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Length
        {
            get { return length; }
            init
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }
                length = value;
            }
        }
        public double SurfaceArea()
        {
            double area = 2 * length * width + 2 * length * height + 2 * height * width;
            return area;
        }
        public double LateralSurfaceArea()
        {
            double area = 2 * length * height + 2 * width * height;
            return area;
        }
        public double Volume()
        {
            double area = length * width * height;
            return area;
        }

    }
}
