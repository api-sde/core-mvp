using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AgentMvp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            await GetWeather();
            Console.ReadKey();
        }
        
        
        
        private static async Task<string> GetWeather()
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync("http://localhost:5001/weatherforecast");
            return result;
        }
    }
}