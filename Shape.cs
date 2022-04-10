namespace ShapeProject
{
    public abstract class Shape
    {
        private int width;
        private int height;
        private int raduis;
        public Shape(int Width, int Height)
        {
            this.width = Width;
            this.height = Height;
        }
        public Shape(int Raduis)
        {
            this.raduis = Raduis;
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Raduis
        {
            get { return raduis; }
            set { raduis = value; }
        }

        public abstract double CalculateSurfaceArea();

    }
}