using System;

namespace amocanaN1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region amocana1

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int a = Convert.ToInt32(input1);
            int b = Convert.ToInt32(input2);

            if (a % b == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            #endregion

            #region amocana3

            string inp1 = Console.ReadLine();
            string inp2 = Console.ReadLine();

            int x = Convert.ToInt32(inp1);
            int y = Convert.ToInt32(inp2);

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            #endregion

            #region amocana4
            string number = Console.ReadLine();
            int samravli = Convert.ToInt32(number);

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(samravli * i);
            }
            #endregion

            #region amocana5

            var input = Console.ReadLine();
            int numb = Convert.ToInt32(input);
            var z = 1;
            while (numb >= z)
            {
                if (z % 2 == 0)
                {
                    Console.WriteLine(z * z);
                }

                z++;
            }

            #endregion
        }
    }
}
