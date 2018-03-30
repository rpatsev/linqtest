using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = {

            new Book("LINQ", 2004, "Author1"),
            new Book("aaa", 2000, "Author3"),
            new Book("ccc", 1994, "Author1"),
            new Book("LINQ Basics", 1996, "Author1"),
            new Book("ccc", 1996, "Author2"),
            new Book("www", 2008, "Author1"),
            new Book("sql", 1997, "Author4"),

        };

            var filteredBooks = books.Where(book => book.Name.Contains("LINQ")).Where(book => book.Year % 4 == 0);

            foreach (Book book in filteredBooks)
            {
                Console.WriteLine(book.Name);
            }

            Console.WriteLine("--------------------------------------------------");

            string russianText = @"Роковая встреча приводит к обвинению в убийстве и 
                                становится тем немыслимым событием, которое делит жизнь Ивон на «до» и «после»";

            char[] extraChars = { ' ', '«', '»', '!', '&' };
            int rusTextArray = russianText.Distinct().Except(extraChars).Count();
            Console.WriteLine(rusTextArray);

            Console.WriteLine("--------------------------------------------------");

            int[] integerArray = { 33, 32, 20, 23, 12, 14 };
            var filteredIntegerArray = string.Join(",", integerArray.OrderBy(num => num % 10).ThenByDescending(num => num - (num % 10)));

            Console.WriteLine(filteredIntegerArray);


            Console.WriteLine("--------------------------------------------------");

            var booksCountByEveryAuthor = books.GroupBy(_ => _.Author).Select(_ => $"{ _.Key} : { _.Count() }").ToList();


            foreach (string book in booksCountByEveryAuthor)
            {
                Console.WriteLine(book);
            }
        }
    }
}

