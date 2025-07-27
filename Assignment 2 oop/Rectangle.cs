namespace Assignment_2_oop
{
    internal struct Rectangle
    {
        private double width;
        private double height;
        public void setWidth(double width)
        {
            if (width >=0)
            {
                this.width = width;
            }
            else
            {
                Console.WriteLine("Error , Dont put negative value");
            }
        }
        public void setHeight(double height)
        {
            if (height >= 0)
            {
                this.height = height;
            }
            else
            {
                Console.WriteLine("Error , Dont put negative value");
            }
        }
        public double getWidth()
        {
            return this.width;
        }
        public double getHeight()
        {
            return this.height;
        }
        public double Area
        {
            get { return width * height; }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Area: {Area}");
        }

    }
}
