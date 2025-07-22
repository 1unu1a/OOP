namespace Deck_of_cards;

public class Deck
{
    private List<Card> cards;

    public Deck(List<Card> cards)
    {
        this.cards = cards;
    }

    private Random random = new();
    
    public Card TakeCard()
    {
        if (cards.Count == 0)
            return null;

        int index = random.Next(cards.Count);
        var card = cards[index];
        cards.RemoveAt(index);
        return card;
    }

    public int CardsLeft => cards.Count;
}