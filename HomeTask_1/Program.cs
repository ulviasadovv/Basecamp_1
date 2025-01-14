namespace HomeTask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int length = number.Length;
            int result = 0;

            for (int i = 0; i <= (length - 1) / 2; i++)
            {
                if (number[i] == number[length - 1 - i])
                {
                    result++;
                }
            }

            Console.WriteLine(result);



            // 2) Olimpiada iştirakçılarının sayı

            string input = Console.ReadLine();
            string[] parts = input.Split();

            double k = double.Parse(parts[0]);
            double m = double.Parse(parts[1]);
            double n = double.Parse(parts[2]);
            double d = double.Parse(parts[3]);

            double s = 0;

            for (double i = 1; i <= 1000; i++)
            {
                if ((i * 1 / k) + (i * 1 / m) + (i * 1 / n) + d == i)
                {
                    s = i;
                    break;
                }
            }

            Console.WriteLine(s);
        }

    }
}
