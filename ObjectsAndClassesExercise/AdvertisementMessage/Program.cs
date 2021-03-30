using System;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            AdvertisementMessage adMessage = new AdvertisementMessage();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(adMessage.ToString());
            }
        }

        public class AdvertisementMessage
        {
            Random rand = new Random();

            public string[] Phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            public string[] Events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            public string[] Authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            public string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            public override string ToString()
            {
                return $"{Phrases[rand.Next(0, Phrases.Length)]} {Events[rand.Next(0, Events.Length)]} {Authors[rand.Next(0, Authors.Length)]} – {Cities[rand.Next(0, Cities.Length)]}";
            }
        }
    }
}
