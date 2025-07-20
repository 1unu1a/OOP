namespace Shop.System
{
    internal class Program // ДЗ: Магазин
    {
        static void Main(string[] args)
        {
            ItemFactory factory = new ItemFactory();
            List<Item> items = factory.CreateDefaultItems();

            Seller seller = new(items);
            Buyer buyer = new Buyer();

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Посмотреть товары продавца");
                Console.WriteLine("2 - Купить товар");
                Console.WriteLine("3 - Показать свои вещи");
                Console.WriteLine("0 - Выход");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        seller.ShowItems();
                        break;
                    case "2":
                        seller.ShowItems();
                        Console.WriteLine("Введите номер товара для покупки:");

                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            if (seller.TrySellItem(index - 1, out Item item))
                            {
                                buyer.TakeItem(item);
                                Console.WriteLine($"Вы купили: {item.Name}");
                            }
                            else
                            {
                                Console.WriteLine("Неверный номер товара.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Введите корректное число.");
                        }
                        break;

                    case "3":
                        buyer.ShowInventory();
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