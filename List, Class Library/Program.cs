namespace List__Class_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("Python", "Luciano Ramalho", 1000);
            Book book2 = new Book("Csharp", "Andrew StelLMAN", 850);

            library.AddBook(book1);
            library.AddBook(book2);

            Console.WriteLine("----------------------------------");

            List<Book> wantedBooks1 = library.FindAllBooksByName("qatar");
            wantedBooks1.ForEach(book => Console.WriteLine(book));

            Console.WriteLine("----------------------------------");

            Console.WriteLine(library.FindBookByCode("p123"));

            Console.WriteLine("----------------------------------"); 

            library.RemoveAllBooksByName("program");
            library.GetBooks().ForEach(book => Console.WriteLine(book));

            Console.WriteLine("----------------------------------");

            List<Book> wantedBooks2 = library.SearchBooks("128");
            wantedBooks2.ForEach(book => Console.WriteLine(book));

            Console.WriteLine("----------------------------------");

            List<Book> wantedBooks3 = library.FindAllBooksByPageCountRange(50, 200);
            wantedBooks3.ForEach(book => Console.WriteLine(book));

            Console.WriteLine("----------------------------------");

            library.RemoveBookByCode("ma128");
            library.GetBooks().ForEach(book => Console.WriteLine(book));
        }
    }
}
