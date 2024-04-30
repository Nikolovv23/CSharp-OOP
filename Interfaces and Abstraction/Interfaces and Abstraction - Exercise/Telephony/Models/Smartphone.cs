using Telephony.Models.Interfaces;

namespace Telephony
{
     public class Smartphone : ICaller , IBrowser
     {
        public void Call (string phoneNumber)
        {
            Console.WriteLine($"Calling... {phoneNumber}");
        }
        public void Browse (string url)
        {
            Console.WriteLine($"Browsing: {url}!");
        }
     }
}
