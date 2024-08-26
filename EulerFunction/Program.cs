namespace EulerFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedit 4islo");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Число Елера {EulerFunction(a)}");

        }
        static int EulerFunction(int number)
        {
            double temp = 1;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    temp *= ((Math.Pow(i, 1) - Math.Pow(i, 0)));
                }
                else if (number / i == 1)
                {
                    break;
                }
            }
            return Convert.ToInt32(temp);
        }
    }
}
