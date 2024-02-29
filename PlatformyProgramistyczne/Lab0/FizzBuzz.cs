namespace PlatformyProgramistyczne.Lab0
{
    internal class FizzBuzz
    {
        int limit;
        public FizzBuzz(int limit)
        {
            this.limit = limit;
        }

        public FizzBuzz()
        {
            limit = 100;
        }

        public void Display()
        {
            for (int i = 1; i <= limit; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
