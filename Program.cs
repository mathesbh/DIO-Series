using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepository repository = new SerieRepository();
        static void Main(string[] args)
        {
            string userOption = UserMenu();

            while(userOption.ToUpper() != "X")
            {
                switch(userOption)
                {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        InsertSerie();
                        break;
                    case "3":
                        UpdateSerie();
                        break;
                    case "4":
                        DeleteSerie();
                        break;
                    case "5":
                        ShowSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            userOption = UserMenu();
            }
        }

    private static void ShowSerie()
    {
      throw new NotImplementedException();
    }

    private static void DeleteSerie()
    {
      throw new NotImplementedException();
    }

    private static void UpdateSerie()
    {
      throw new NotImplementedException();
    }

    private static void InsertSerie()
    {
      throw new NotImplementedException();
    }

    private static void ListSeries()
    {
      throw new NotImplementedException();
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
