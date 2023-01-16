namespace CMS.Application
{
    public abstract class Shape
    {
        public double width, height, radius;
        public const float pi = 3.14f;
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area()
        {
            return width*height;
        }

    }
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            this.radius = radius;   
        }
        public override double Area()
        {
            return pi*radius*radius;
        }
    }
    public class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area()
        {
            return (0.5*width*height);
        }
    }
    public class TryAbstract
    {
        static void Main(string[] args)
        {
            Rectangle ob_rectangle = new Rectangle(12.23, 23.12);
            Circle ob_circle = new Circle(12.23);
            Triangle ob_triangle = new Triangle(12.23, 23.12);

            System.Console.WriteLine("Area of Rectangle: "+ob_rectangle.Area()+" sq Unit");
            System.Console.WriteLine("Area of Circle: "+ob_circle.Area()+" sq Unit");
            System.Console.WriteLine("Area of Triangle: "+ob_triangle.Area()+" sq Unit");
        }
    }
}