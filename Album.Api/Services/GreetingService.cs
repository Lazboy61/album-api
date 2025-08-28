using System.Net;

namespace Album.Api.Services
{
    public class GreetingService
    {
        public string Greet(string name)
        {
            var hostname = Dns.GetHostName();
            if (string.IsNullOrWhiteSpace(name))
                return $"Hello World from {hostname} v2";
            return $"Hello {name} from {Dns.GetHostName()} v2";



        }
    }
}
