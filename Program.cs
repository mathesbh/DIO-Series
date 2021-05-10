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
      Console.WriteLine("5- Show serie");
      
      int id = int.Parse(Console.ReadLine());

      var serie = repository.FindById(id);

      Console.WriteLine(serie.Details());
    }

    private static void DeleteSerie()
    {
      Console.WriteLine("4- Delete serie");

      Console.WriteLine("Type the Id of the serie: ");
      int id = int.Parse(Console.ReadLine());
      repository.Delete(id);
    }

    private static void UpdateSerie()
    {
      throw new NotImplementedException();
    }

    private static void InsertSerie()
    {
      Console.WriteLine("2- To insert new serie");

      foreach (int item in Enum.GetValues(typeof(Genres)))
      {
          Console.WriteLine("{0}-{1}", item, Enum.GetName(typeof(Genres), item));
      }

      Console.Write("Choose a genre referring to the items above: ");
      int genre = int.Parse(Console.ReadLine());

      Console.Write("Type the title of the series: ");
      string title = Console.ReadLine();

      Console.Write("Type the release year of the serie: ");
      int year = int.Parse(Console.ReadLine());

      Console.Write("Type the description of the serie: ");
      string description = Console.ReadLine();

      Serie newSerie = new Serie(id: repository.NextId(), genres: (Genres)genre, title: title, year: year, description: description);

      repository.Save(newSerie);    
    }

    private static void ListSeries()
    {
      Console.WriteLine("1- To list series");

      var list = repository.FindAll();

      if(list.Count == 0)
      {
          Console.WriteLine("No series registered");
          return;
      }

      foreach (var item in list)
      {
          var delete = item.ReturnDelete();
        
        Console.WriteLine("#ID {0}: - {1} {2}", item.getId(), item.getTitle(), (delete ? "*Delete*" : ""));
      }

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
