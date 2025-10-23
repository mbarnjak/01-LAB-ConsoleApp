using ConsoleApp.Modeli;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Proizvod proizvod = new Proizvod("Laptop torba", 49.99m, 25);
            proizvod.IspisiInformacije();

            
            PametniTelefon telefon = new PametniTelefon("Galaxy S25", "Samsung", 2025, "Android 15");
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju("WhatsApp");

            Console.ReadLine();

        }
    }
}
