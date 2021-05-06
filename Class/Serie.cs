namespace DIO.Series
{
    public class Serie : Entity
    {
        private Genres Genres { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        public Serie(int id, Genres genres, string title, string description, int year)
        {
            this.Id = id;
            this.Genres = genres;
            this.Title = title;
            this.Description = description;
            this.Year = year;
        }
    }
}