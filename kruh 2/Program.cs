using System;

namespace kruh_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double polomer;
            double obvod;
            double obsah;
            double prumer;
            double vyber;
            Console.WriteLine("KRUH");

            Console.WriteLine("Vyber z mozností 1 prumer   2 polomer");
            double.TryParse(Console.ReadLine(), out vyber);
            

            if (vyber == 1)
            {
                Console.WriteLine("Zadej prumer");
                Double.TryParse(Console.ReadLine(), out prumer);
                

                obvod = 3.14 * prumer;
                Console.WriteLine($"Obvod je {obvod}");
                obsah = 3.14 * (prumer * prumer) / 4;
                Console.WriteLine($"Obsah je { obsah}");
            }
        
            else if (vyber == 2)
            {
                Console.WriteLine("Zadej polomer");
                Double.TryParse(Console.ReadLine(), out polomer);
                double.TryParse(Console.ReadLine(), out vyber);
                
                obvod = 2 * 3.14 * polomer;
                Console.WriteLine($"Obvod kruhu je  {obvod}");

                obsah = 3.14 * (polomer * polomer);
                Console.WriteLine($"Obsah kruhu je {obsah}");




            }












        }
    }
}
