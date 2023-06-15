using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanyeAndRon
{
    public class DontQuoteMe
    {
        public static void KQuote() 
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine($"Real Dumb Says: {kanyeQuote}");
            Console.WriteLine();
        }
        public static void RQoute()
        {
            var client = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Replace('"',' ').Trim();
            Console.WriteLine($"Wiseman Says: {ronQuote}");
            Console.WriteLine();
        }
    }
}
