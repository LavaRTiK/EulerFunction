namespace EulerFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedit 4islo");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Число Елера {EulerFunction(a)}");
            Console.WriteLine($"Число по фасту{EulerFunction2(a)}");
            Console.WriteLine($"EluerFunction3   {EluerFunction3(a)}");
            //string s = "2+2";
            //Console.WriteLine(Convert.ToInt32(s));

        }
        static int EulerFunction(int number)
        {
            double temp = 1;
            double test = number;
            for (int i = 2; i <= test; i++)
            {
                if (test % i == 0)
                {
                    temp *= ((Math.Pow(i, 1) - Math.Pow(i, 0)));
                    test = test / i;
                    i = 2;

                }
                else if (test / i == 1)
                {
                    Console.WriteLine("закончил на " , i);
                    break;
                }
            }
            return Convert.ToInt32(temp);
        }
        static int EulerFunction2(int number)
        {
            int test = 0;
            for (int i = 1; i < number; i++)
            {
                if(number / i == 0)
                {
                    test++;
                }
            }
            return test;
        }
        static int EluerFunction3(int number)
        {
            double temp = 1;
            double test = number;
            List<int> list = new List<int>();
            for (int i = 2; i <= test; i++)
            {
                if(test % i == 0)
                {
                    list.Add(i);
                    test = test / i;
                    i = 1;
                }
                else if (test/i == 1)
                {
                    break;
                }
            }
            while (list.Count > 0)
            {
                temp *= ((Math.Pow(list[0], list.Count(x => x == list[0])) - Math.Pow(list[0], list.Count(x => x == list[0])-1)));
                list.RemoveAll(x => x == list[0]);
            }
            return Convert.ToInt32(temp);
        }
    }
}
