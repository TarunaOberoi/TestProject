using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions obj = new Functions();
	        int result = obj.add(10,12);
            Console.WriteLine("Add of Two Number Is - " + result);
            Console.ReadLine();
        }
    }
}
