namespace Album.Api.Services
{
    public class GreetingService
    {
        public string Greet(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "Hello World";

            return $"Hello {name}";
        }
    }
}
