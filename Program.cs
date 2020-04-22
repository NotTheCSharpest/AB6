using System;

namespace AB6_1

{
    class Program
    {
        static void Main(string[] args)
        {
            double Indien = 700000000;
            double China = 990000000;
            int i = 1987;
            while (Indien < China)
            {
                Indien = Indien * .021;
                China = China * .014;
                i++;
            }
            Console.WriteLine("Bevolkerungsanzahl Indien: {0} \n Bevolkerungsanzahl China: {1} \n Indien ist grosser in Jahr {2}", Indien, China, i);
                    }
    }
}
