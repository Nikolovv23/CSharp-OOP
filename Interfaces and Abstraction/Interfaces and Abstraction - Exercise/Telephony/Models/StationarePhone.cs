
using Telephony.Models.Interfaces;

namespace Telephony
{
    public class StationarePhone : ICaller
    {
        public void Call(string number)
        {
            Console.WriteLine($"Dialing... {number}"); ;
        }
    }
}
