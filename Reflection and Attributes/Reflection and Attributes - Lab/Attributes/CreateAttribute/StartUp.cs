// Create attribute Author with a string element called name, that:
// •	Can be used over classes and methods
// •	Allow multiple attributes of the same type

namespace AuthorProblem
{
    [Author("Victor")]
    class StartUp
    {
        [Author("George")]
        static void Main(string[] args)
        {
        }
    }
}
