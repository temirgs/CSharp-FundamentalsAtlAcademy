using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin");
            int val1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin");
            int val2 = Convert.ToInt16(Console.ReadLine());
           
            Test test = new Test();
            int result = test.Cem(val1, val2);
            Console.WriteLine("iki edein Cemi");
            Console.Write(result);
        }
    }

    class Test
    {
        public int Cem(int a, int b)
        {
            return a + b;
        }
    }
}
