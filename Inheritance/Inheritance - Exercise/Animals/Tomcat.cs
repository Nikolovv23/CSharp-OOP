namespace Animals
{
    public class Tomcat : Cat
    {
        private const string TomCatGender = "male";
        public Tomcat(string name, int age) : base(name, age, TomCatGender)
        {
        }
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
