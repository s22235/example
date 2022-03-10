using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static async Task main(string[] args)
        {
            var websiteURL = args[0];
            HttpClient htttpClient = new HttpClient();
            HttpResponseMessage response = await htttpClient.GetAsync(websiteURL);
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            Regex regex = new Regex(@"");
            MatchCollection matchCollection = regex.Matches(content);
           
            foreach (var item in matchCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
