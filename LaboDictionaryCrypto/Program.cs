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
            foreach (var coin in crypto)
            {
                Console.WriteLine($"{coin.Key}: {coin.Value,4} coins");
            }

        }
    }
}
