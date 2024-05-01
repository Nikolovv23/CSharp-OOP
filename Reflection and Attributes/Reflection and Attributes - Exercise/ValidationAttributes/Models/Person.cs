
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models
{
    public class Person
    {
        private const int MinAge = 12;
        private const int MaxAge = 90;
        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

        [MyRequiredattribute]
        public string FullName { get; set; }

        [MyRangeAttribute (MinAge,MaxAge)]
        public int Age { get; set; }
    }
}
