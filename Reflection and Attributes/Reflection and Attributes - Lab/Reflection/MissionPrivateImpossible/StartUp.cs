// It’s time to see what this hacker you are dealing with aims to do.  Create a method inside your Spy class called -RevealPrivateMethods(string className).
// Print all private methods in the following format:
// All Private Methods of Class: { className}
// Base Class: { baseClassName}
// On the next lines, print found method’s names each on a new line.Use StringBuilder to concatenate the answer. Don’t change anything in Hacker class

//     Output
// All Private Methods of Class: Stealer.Hacker
// Base Class: Object
// get_Id
// set_Id
// set_BankAccountBalance
// MemberwiseClone
// Finalize

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            /*Spy spy = new Spy();
            string result = spy.StealFieldInfo("Stealer.Hacker", "username", "password");
            Console.WriteLine(result);*/

            /*  Spy spy = new Spy();
              string result = spy.AnalyzeAccessModifiers("Stealer.Hacker");
              Console.WriteLine(result);*/

            Spy spy = new Spy();
            string result = spy.RevealPrivateMethods("Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}
