// Look at the image in the Hierarchy folder and build a hierarchy of interfaces and classes: 

// Input
// 3
// 4
// 5
// Output
//    *******
//  **       **
// **         **
// *           *
// **         **
//  **       **
//    *******
// ****
// *  *
// *  *
// *  *
// ****


namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var radius = int.Parse(Console.ReadLine());

            IDrawable circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());

            var height = int.Parse(Console.ReadLine());

            IDrawable rect = new Rectangle(width, height);

            circle.Draw();

            rect.Draw();
        }
    }
}
