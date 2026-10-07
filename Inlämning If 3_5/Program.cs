using System;
namespace inlämningIf_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            int förstaTal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in ett till tal");
            int andraTal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Välj något av följande alternativ: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            string svar = Console.ReadLine();

            switch (svar)
            {
                case "1":
                    Console.WriteLine("Summan av talen är: " + (förstaTal + andraTal));
                    break;
                case "2":
                    Console.WriteLine("Differensen av talen är: " + (förstaTal - andraTal));
                    break;
                case "3":
                    Console.WriteLine("Produkten av talen är: " + (förstaTal * andraTal));
                    break;
                case "4":
                    {
                        Console.WriteLine("Kvoten av talen är: " + (förstaTal / andraTal));

                        break;
                    }
                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;




            }
        }
    }
}
