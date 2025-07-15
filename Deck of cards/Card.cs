namespace Deck_of_cards;

public class Card
{
    public string Suit { get; }
    public string Rank { get; }

    public Card(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public string GetCardInfo()
    {
        return $"{Rank} - {Suit}";
    }
}