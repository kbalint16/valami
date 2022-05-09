using System;

namespace Etel
{
    class Program
    {
        static void Main(string[] args)
        {
            Tej[] Tejek = new Tej[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Add meg az egysegarat");
                int egysegar = Convert.ToInt32(Console.ReadLine());
                if(egysegar<150||egysegar>220)
                {
                    Console.WriteLine("150 és 220 között kell lenni");
                    break;
                }

                Console.WriteLine("Add meg a gyartot");
                string gyarto = Console.ReadLine();

                Console.WriteLine("Add meg a gyartasi idot:");
                DateTime gyartasiido = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Add meg a lejarati idot:");
                DateTime lejaratiido = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Add meg a tipusat Zsiros(0)/Felzsiros(1)");
                int tipusszint = Convert.ToInt32(Console.ReadLine());
                if (tipusszint > 2)
                {
                    Console.WriteLine("nem jo tipus");
                    break;
                }
                TejTipus tipus = (TejTipus)tipusszint;

                Console.WriteLine("Add meg a kisezerelest Literes(0)/Felliteres(1)/Poharas(2)");
                int kiszereles = Convert.ToInt32(Console.ReadLine());
                if (kiszereles > 3)
                {
                    Console.WriteLine("nem jo kiszereles");
                    break;
                }
                AdagKiszereles adottkiszereles = (AdagKiszereles)kiszereles;


            }
        }
    }
}
