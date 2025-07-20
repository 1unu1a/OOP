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
                Console.WriteLine("Введите имя автора для поиска (или 'exit' для выхода):");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;                    
                }

                AuthorFilter filter = new AuthorFilter(input);
                
                bool found = false;
                foreach (Book book in library.GetAllBooks())
                {
                    if (filter.Matches(book))
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine($"Книг автора '{input}' не найдено. Попробуйте снова.\n");
                    continue;
                }

                Console.WriteLine($"Книги автора '{input}':");
                library.ShowBooksByFilter(filter);
            }
        }
    }
}