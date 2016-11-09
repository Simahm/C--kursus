using System;

namespace VariabelOvelse
{
    class Program
    {

        /// <summary>
        /// Documentation header for the enum.
        /// </summary>
        private enum FilTyper
        {
            /// <summary>
            /// documentation header
            /// </summary>
            csv,

            /// <summary>
            /// documentation header
            /// </summary>
            pdf,

            /// <summary>
            /// documentation header
            /// </summary>
            txt
        }

        static void Main(string[] args)
        {
            int heltal = 10;
            Console.WriteLine("Heltal:");

            heltal++;
            Console.WriteLine(heltal);

            heltal--;
            Console.WriteLine(heltal);

            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal = 12.5;

            Console.WriteLine("kommatal:");

            kommatal++;
            Console.WriteLine(kommatal);

            kommatal--;
            Console.WriteLine(kommatal);

            kommatal *= 2;
            Console.WriteLine(kommatal);

            Console.WriteLine("Filtype:");

            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            Console.WriteLine("Dato:");

            DateTime dato = DateTime.Now;
            Console.WriteLine(dato.ToString());
            Console.WriteLine("longDate: " + dato.ToLongDateString());
            Console.WriteLine("shortDate: " + dato.ToShortDateString());

            Console.WriteLine("Person:");

            Person p;
            p.Id = 1;
            p.Navn = "Simon";
            Console.WriteLine(p.Navn);
            Console.WriteLine(p.Id);

            Console.ReadKey();
        }

        private struct Person
        {
            public int Id;
            public string Navn;
        }

    }
}
