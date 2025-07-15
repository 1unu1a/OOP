namespace Deck_of_cards;

internal class Program //ДЗ: Колода карт
{
    static void Main(string[] args)
    {
        Deck deck = new Deck();
        Player player = new Player();

        Console.WriteLine("Сколько карт из колоды взять?");
        int count;

        while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
        {
            Console.WriteLine("Введите положительное число:");
        }

        player.DrawCards(deck, count);
        player.ShowHand();

        Console.WriteLine($"\nОсталось карт в колоде: {deck.CardsLeft}");
    }
}