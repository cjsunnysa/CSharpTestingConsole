using OutputConsole._1_Parameters;
using OutputConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IRunnable[] programs = new IRunnable[]
            {
                new ParamsRefOut(),
            };

            foreach (var program in programs)
            {
                Console.WriteLine("==============================================");
                Console.WriteLine();
                Console.WriteLine($"Running - {program.Title}");
                Console.WriteLine();

                var result = program.Run();

                Console.WriteLine();
                Console.WriteLine($"WasSuccess: {result.Success}");

                if (!result.Success)
                    Console.WriteLine($"Error: {result.ErrorMessage}");

                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
