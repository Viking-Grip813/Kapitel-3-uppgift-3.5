using System;
namespace uppgift3_5
{ class Program
    { static void Main(string[] args)
        {
            Console.WriteLine("Skriv två heltal");
            int heltal1 = int.Parse(Console.ReadLine());
            int heltal2 = int.Parse(Console.ReadLine());
            int addition = heltal1 + heltal2;
            int subtraktion = heltal1 - heltal2;
            int multiplikation = heltal1 * heltal2;
            int Division = heltal1 / heltal2;
         
           
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            string Alternativ = Console.ReadLine();
            switch (Alternativ)
            {
                case "1":
                    Console.WriteLine("Resultatet är " + addition);
                    break;
                    case "2":
                    Console.WriteLine("Resultatet är " + subtraktion);
                    break;
                    case "3":
                    Console.WriteLine("Resultatet är " + multiplikation);
                    break;
                    case "4":
                    Console.WriteLine("Resultatet är " + Division);
                    break;


            }



        }
    }
}
