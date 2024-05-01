// Create a class hierarchy, starting with abstract class Shape :
// •	Abstract methods:
// o CalculatePerimeter(): double
// o	CalculateArea(): double
// •	Virtual methods:
// o Draw(): string
// 	The method should get the name of class type as string, and should return a message in the format: $"Drawing {classType.Name}"
// Extend the Shape class with two children:
// •	Rectangle
// •	Circle
// Each of them needs to have: 
// •	Fields:
// o height and width for Rectangle
// o	radius for Circle
// •	Encapsulation for these fields
// •	A public constructor 
// •	Concrete methods for calculations (perimeter and area)
// •	Override methods for drawing 

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(3.00);
            Shape rectangle = new Rectangle(2 , 5);

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(rectangle.CalculateArea());

            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(rectangle.CalculatePerimeter());

            Console.WriteLine(circle.Draw());
            Console.WriteLine(rectangle.Draw());
        }
    }
}
