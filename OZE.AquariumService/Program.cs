using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace OZE.AquariumService
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                await client.GetAsync("http://192.168.8.133/turnOn");

                Thread.Sleep(10000);

                await client.GetAsync("http://192.168.8.133/turnOff");
            }
        }   
    }
}
