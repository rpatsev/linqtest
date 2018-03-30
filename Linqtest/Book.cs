namespace LinqTest
{
    public class Book
    {
        public string Name;
        public int Year;
        public string Author;

        public Book(string name, int year, string author = "noAuthor")
        {
            this.Name = name;
            this.Year = year;
            this.Author = author;
        }
    }
}