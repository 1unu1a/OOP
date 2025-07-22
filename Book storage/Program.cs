namespace My.Home.Work.Oop
{
    internal class Program //ДЗ: Хранилище книг
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            
            library.AddBook(new Book("Война и мир", "Толстой", 1869));
            library.AddBook(new Book("Анна Каренина", "Толстой", 1878));
            library.AddBook(new Book("Преступление и наказание", "Достоевский", 1866));
            library.AddBook(new Book("Бесы", "Достоевский", 1872));
            library.AddBook(new Book("Капинтанская дочка", "Пушкин", 1836));
            library.AddBook(new Book("Евгений Онегин", "Пушкин", 1831));

            library.ShowAllBooks();
            
            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Добавить книгу");
                Console.WriteLine("2. Показать все книги");
                Console.WriteLine("3. Удалить книгу");
                Console.WriteLine("4. Найти книги по автору");
                Console.WriteLine("5. Найти книги по названию");
                Console.WriteLine("6. Найти книги по году");
                Console.WriteLine("0. Выход");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Введите название:");
                        string title = Console.ReadLine();
                        Console.WriteLine("Введите автора:");
                        string author = Console.ReadLine();
                        Console.WriteLine("Введите год:");
                        int year;
                        while (!int.TryParse(Console.ReadLine(), out year))
                        {
                            Console.WriteLine("Введите корректный год:");
                        }
                        library.AddBook(new Book(title, author, year));
                        break;

                    case "2":
                        library.ShowAllBooks();
                        break;
                    
                    case "3":
                        Console.WriteLine("Введите название книги для удаления:");
                        string removeTitle = Console.ReadLine();

                        Console.WriteLine("Введите автора:");
                        string removeAuthor = Console.ReadLine();

                        Console.WriteLine("Введите год издания:");
                        if (int.TryParse(Console.ReadLine(), out int removeYear))
                        {
                            Book bookToRemove = new Book(removeTitle, removeAuthor, removeYear);
                            library.RemoveBook(bookToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Некорректный год.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Введите автора:");
                        string authorFilter = Console.ReadLine();
                        List<Book> byAuthor = library.FindBooksByAuthor(authorFilter);
                        library.ShowBooks(byAuthor);
                        break;

                    case "5":
                        Console.WriteLine("Введите название:");
                        string titleFilter = Console.ReadLine();
                        List<Book> byTitle = library.FindBooksByTitle(titleFilter);
                        library.ShowBooks(byTitle);
                        break;

                    case "6":
                        Console.WriteLine("Введите год:");
                        int yearFilter;
                        while (!int.TryParse(Console.ReadLine(), out yearFilter))
                        {
                            Console.WriteLine("Введите корректный год:");
                        }
                        List<Book> byYear = library.FindBooksByYear(yearFilter);
                        library.ShowBooks(byYear);
                        break;

                    case "0":
                        Console.WriteLine("До свидания!");
                        return;

                    default:
                        Console.WriteLine("Неизвестная команда.");
                        break;
                }
            }
        }
    }
}