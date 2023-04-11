using System;
namespace project
{
    class test
    {
        public static  void Main()
        {
            Console.WriteLine("inter lenth");
            int L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inter width");
            int W = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inter hieght");
            int H = Convert.ToInt32(Console.ReadLine());
            calc(L, W, H);
        }
        private static void calc(int x, int y, int z)
        {
            Double Result = x * y * z;
            Console.WriteLine(Result);
        }
    }
}