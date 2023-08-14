namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle shape1 = new Rectangle();

            Console.WriteLine("Area of shape : " + shape1.CalculateArea());
            Console.WriteLine("Perimetr of shape : " + shape1.CalculatePerimetr());
            Console.WriteLine("Diagonal of shape : " + shape1.CalculatePerimetr());

            Circle shape2 = new Circle();

            Console.WriteLine("Circle's area : " + shape2.CalculateArea());
            Console.WriteLine("Circle's perimetr : " + shape2.CalculatePerimetr());
        }
    }
    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculatePerimetr() => 2 * (Width + Height);
        public double CalculateArea() => Width * Height;
        public double CalculateDiagonal()
        {
            return Math.Sqrt((Width * Width) + (Height * Height));
        }
        //Constructors
        public Rectangle() 
        {
            Width = 1;
            Height = 1;
        }
        public Rectangle (double width , double height)
        {
            Width = width;
            Height = height;
        }
    }
    class Circle
    {
        public double Radius { get; set; }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public double CalculatePerimetr()
        {
            return 2 * Math.PI * Radius; 
        }   
        //Constructors
        public Circle()
        {
            Radius = 1;
        }
        public Circle(double radius)
        {
            Radius = radius; 
        }
    }
}