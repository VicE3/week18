using System;

namespace cChall1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");

            var userInput = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter another number");

			var userInput2 = Convert.ToInt32(Console.ReadLine());

            var result = Divide(userInput, userInput2);

            Console.WriteLine(result);

        }

        public static int Divide(int userInput, int userInput2) 
        {
            int answer = userInput / userInput2;
            return answer;
        }


	}
}
