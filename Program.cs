using System;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            string userOption = UserMenu();
        }
        private static string UserMenu()
		{
			Console.WriteLine();
			Console.WriteLine("Select an option from the menu:");

			Console.WriteLine("1- To list series");
			Console.WriteLine("2- To insert new serie");
			Console.WriteLine("3- To update serie");
			Console.WriteLine("4- Delete serie");
			Console.WriteLine("5- Show serie");
			Console.WriteLine("C- To clean window");
			Console.WriteLine("X- To exit");
			Console.WriteLine();

			string userOption = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return userOption;
		}
    }
}
