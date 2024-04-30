

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty() => Count == 0;
        public void AddRange(Stack<string> elements)
        {
            foreach (string element in elements)
            {
                Push(element);
            }
        }
    }

}
