// Create two classes named Animal and Dog:
// •	Animal with a single public method Eat() that prints: "eating…"
// •	Dog with a single public method Bark() that prints: "barking…"
// •	Dog should inherit from Animal

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Eat();
        }
    }
}
