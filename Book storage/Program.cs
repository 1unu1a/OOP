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
                        AddBookFlow(library);
                        break;

                    case "2":
                        library.ShowBooks(library.GetAllBooks());
                        break;
                    
                    case "3":
                        RemoveBookFlow(library);
                        break;

                    case "4":
                        Console.WriteLine("Введите автора:");
                        string author = Console.ReadLine();
                        library.ShowBooks(library.FindBooks(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)));
                        break;

                    case "5":
                        Console.WriteLine("Введите название:");
                        string title = Console.ReadLine();
                        library.ShowBooks(library.FindBooks(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase)));
                        break;

                    case "6":
                        Console.WriteLine("Введите год:");
                        if (int.TryParse(Console.ReadLine(), out int year))
                        {
                            library.ShowBooks(library.FindBooks(b => b.Year == year));
                        }
                        else
                        {
                            Console.WriteLine("Некорректный год.");
                        }
                        break;

                    case "0":
                        Console.WriteLine("До свидания!");
                        return;

                    default:
                        Console.WriteLine("Неизвестная команда.");
                        break;
                }
            }
            static void AddBookFlow(Library library)
            {
                Console.WriteLine("Введите название:");
                string title = Console.ReadLine();

                Console.WriteLine("Введите автора:");
                string author = Console.ReadLine();

                Console.WriteLine("Введите год:");
                if (int.TryParse(Console.ReadLine(), out int year))
                {
                    library.AddBook(new Book(title, author, year));
                }
                else
                {
                    Console.WriteLine("Некорректный год.");
                }
            }
            
            static void RemoveBookFlow(Library library)
            {
                Console.WriteLine("Введите название:");
                string title = Console.ReadLine();

                Console.WriteLine("Введите автора:");
                string author = Console.ReadLine();

                Console.WriteLine("Введите год:");
                if (int.TryParse(Console.ReadLine(), out int year))
                {
                    library.RemoveBook(new Book(title, author, year));
                }
                else
                {
                    Console.WriteLine("Некорректный год.");
                }
            }
        }
    }
}