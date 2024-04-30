

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;
        public RandomList()
        {
            this.random = new Random();
        }
        public string RandomString()
        {
            int index = this.random.Next(0, this.Count);
            string  random = this[index];
            this.RemoveAt(index);
            return random;
        }
    }
}
