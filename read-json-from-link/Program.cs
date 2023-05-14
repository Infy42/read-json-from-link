using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;


namespace read_json_from_link
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using(HttpClient client = new HttpClient())
            {
                Uri url = new Uri("https://dummyjson.com/products");

                HttpResponseMessage response = await client.GetAsync(url);
                string responseString = await response.Content.ReadAsStringAsync();

                JsonLinkFetch jsonLink = JsonSerializer.Deserialize<JsonLinkFetch>(responseString);

                jsonLink.DisplayProducts();

                Console.ReadKey();
            }
        }
    }
}
