namespace DIO.Series
{
    public class Serie : Entity
    {
        private Genres Genres { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool Delete { get; set; }
        public Serie(int id, Genres genres, string title, string description, int year)
        {
            this.Id = id;
            this.Genres = genres;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Delete = false;
        }
        public string Details()
        {
            string details = "" ;
            details += "Genre: " + this.Genres + "\n";
            details += "Title: " + this.Title + "\n";
            details += "Description: " + this.Description + "\n";
            details += "Year: " + this.Year + "\n";
            details += "Delete: " + this.Delete;
            return details;
        }
        public string getTitle()
        {
            return this.Title;
        }
        public int getId()
        {
            return this.Id;
        }
        public bool ReturnDelete()
        {
            return this.Delete;
        }
        public void setDelete(){
            this.Delete = true;
        }
    }
}