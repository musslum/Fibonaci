namespace Task7_1
{
    internal class Program
    {
        static void Main(string[] args) // 1 1 2 3 5 8 13 21 34 55
        {
            int a = 1;
            long b = 1;
            long c = 1;
            int n = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < 8; i++)
            {

                c = c + b;
                for (int k = 2; k < c; k++)
                {
                    if (c % k == 0)
                    {
                        n++;
                    }
                }
                if (n == 0)
                {
                    Console.WriteLine(c);
                }
                n = 0;

                b = c - b;


            }

        }



    }
}