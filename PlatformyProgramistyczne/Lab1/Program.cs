using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Test")]
[assembly: InternalsVisibleTo("GUI")]

namespace PlatformyProgramistyczne.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the seed :");
            int seed = int.Parse(Console.ReadLine());
            
            Console.WriteLine(" Enter the capacity :");
            int capacity = int.Parse(Console.ReadLine());

            Plecak plecak = new Plecak(10, seed);
            
            Result result = plecak.Solve(capacity);
            
            Console.WriteLine(result.ToString());


        }
    }
}
