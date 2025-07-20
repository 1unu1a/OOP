namespace Deck_of_cards;

public class Player
{
    public List<Card> Hand { get; } = new();

    public void TakeCards(Deck deck, int number)
    {
        for (int i = 0; i < number; i++)
        {
            Card card = deck.TakeCard();
            if (card != null)
            {
                Hand.Add(card);
            }
        }
    }

    public void ShowHand()
    {
        Console.WriteLine("\nКарты в руке игрока:");
        foreach (var card in Hand)
        {
            Console.WriteLine(card.GetCardInfo());
        }
    }
}