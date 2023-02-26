using WifiModule;
using System;

namespace ConsoleInterface
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            NetworkDataFinder finder = new NetworkDataFinder();

            NetworkData networkData = finder.GetNetworkData(finder.GetCurrentNetworkName());
            
            Console.WriteLine("Nome: " + networkData.Name);
            Console.WriteLine("Senha: " + networkData.Password);
            Console.WriteLine("Seguranca: " + networkData.SecurityType);

            Console.WriteLine("QrCodeString: " + networkData.NetworkDataToWifiStringPattern());

            Console.ReadKey();
        }
    }
}