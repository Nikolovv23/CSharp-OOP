// Use reflection to get all Hacker methods. Then prepare an algorithm that will recognize which methods are getters and setters.
// Print to console each getter on a new line in the format:
// "{name} will return {Return Type}"
// Then print all of the setters in the format:
// "{name} will set field of {Parameter Type}"
// Use StringBuilder to concatenate the answer. Don’t change anything in Hacker class!
// In your Main() method you should be able to check your program with the current piece of code.
// 
//     Output
// get_Password will return System.String
// get_Id will return System.Int32
// get_BankAccountBalance will return System.Double
// set_Password will set field of System.String
// set_Id will set field of System.Int32
// set_BankAccountBalance will set field of System.Double

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

            /* Spy spy = new Spy();
             string result = spy.RevealPrivateMethods("Stealer.Hacker");
             Console.WriteLine(result);*/
            Spy spy = new Spy();
            string result = spy.CollectGettersAndSetters("Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}
