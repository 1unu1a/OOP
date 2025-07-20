namespace Deck_of_cards;

internal class Program //ДЗ: Колода карт
{
    static void Main(string[] args)
    {
        DeckFactory factory = new DeckFactory();
        List<Card> cards = factory.CreateStandardDeck();
        Deck deck = new(cards);
        Player player = new Player();

        Console.WriteLine("Сколько карт из колоды взять?");
        int count;
        
        while (true)
        {
            Console.Write("Введите положительное число: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out count) && count > 0)
            {
                break;
            }

            Console.WriteLine("Ошибка ввода. Попробуйте снова.");
        }

        player.TakeCards(deck, count);
        player.ShowHand();

        Console.WriteLine($"\nОсталось карт в колоде: {deck.CardsLeft}");
    }
}