using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            while (true)
            {
                
                Console.WriteLine("Taş-kağıt-makas oyununa hoş geldiniz!");
                Console.WriteLine("Lütfen seçiminizi yapınız:");
                Console.WriteLine("1 - Taş");
                Console.WriteLine("2 - Kağıt");
                Console.WriteLine("3 - Makas");

                int userChoice; //kullanıcının yapacağı seçim

                while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 3)
                {
                    Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");
                
                }

                int computerChoice = random.Next(1, 4);

                Console.WriteLine("Siz: " + GetChoiceName(userChoice));
                Console.WriteLine("Bilgisayar: " + GetChoiceName(computerChoice));

                if (userChoice == computerChoice)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Berabere!");
                    Console.ResetColor();
                }
                else if ((userChoice == 1 && computerChoice == 3) || (userChoice == 2 && computerChoice == 1) || (userChoice == 3 && computerChoice == 2))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Kazandınız!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Kaybettiniz!");
                    Console.ResetColor();
                }

                while (true)
                {
                    Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");
                    string continueChoice = Console.ReadLine().ToLower();

                    if (continueChoice == "e")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (continueChoice == "h")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Lütfen 'E' veya 'H' harflerinden birini giriniz.");
                    }
                }

            }
        }
        //yapılan seçimin değerini int parametresi olarak alıp onun metinsel karşılığını sunan metot
        static string GetChoiceName(int choice)
        {
            switch (choice)
            {
                case 1:
                    return "Taş";
                case 2:
                    return "Kağıt";
                case 3:
                    return "Makas";
                default:
                    return "";
            }
        }
    }
}
