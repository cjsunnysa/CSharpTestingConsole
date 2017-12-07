using OutputConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutputConsole.Common;

namespace OutputConsole._1_Parameters
{
    public class ParamsRefOut : IRunnable
    {
        public string Title { get => "Parameter Testing"; }

        public RunResult Run()
        {
            try
            {
                int a = 1;
                int b = 1;
                int c = 1;

                Console.WriteLine($"Declare a = {a}");
                Console.WriteLine($"Declare b = {b}");
                Console.WriteLine($"Declare c = {c}");

                Console.WriteLine("Call ManipulateParameters.");

                ManipulateParameters(a, ref b, out c);

                Console.WriteLine("Return from ManipulateParameters.");
                Console.WriteLine($"a = {a}");
                Console.WriteLine($"b = {b}");
                Console.WriteLine($"c = {c}");

                return new RunResult(true);
            }
            catch(Exception ex)
            {
                return new RunResult(false, ex.Message);
            }
        }

        private void ManipulateParameters(int x, ref int y, out int z)
        {
            x += 20;
            y += 20; 
            
            // not possible
            // z += 20;

            z = 20;
        }
    }
}
