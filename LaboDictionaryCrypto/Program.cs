namespace LaboDictionaryCrypto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.1
            Dictionary<string, double> crypto = new Dictionary<string, double>
            {
                {"BTC", 0.5 },
                {"ETH", 2 },
                {"SOL", 10 }
            };

            //3.2
            crypto.Add("XRP", 0.7);
            crypto.Add("ADA", 5);

            //3.1
            foreach (var kv in crypto)
            {
                Console.WriteLine($"{kv.Key}: {kv.Value,4} coins");
            }

            //3.3 
            crypto["ETH"] = 3;
            Console.WriteLine($"De nieuwe hoeveelheid ETH is {crypto["ETH"]} coins.");

            //3.4
            bool inPortfolio = crypto.ContainsKey("SOL");           
            Console.WriteLine(inPortfolio ? "Deze coin zit al in mijn portfolio." : "Deze coin zit nog niet in mijn portfolio.");

            //3.5
            double amount;
            string key = "ABC";
            bool found = crypto.TryGetValue(key, out amount);

            if (found)
            {
                Console.WriteLine($"{key}: {amount} coins");
            }
            else
            {
                Console.WriteLine($"{key} zit nog niet in je portfolio.");
            }

            // Console.WriteLine(crypto["ABC"]); // coin opvragen met indexnotatie via onbestaande key -> KeyNotFoundException

            // 3.6
            crypto.Remove("SOL");

        }
    }
}
