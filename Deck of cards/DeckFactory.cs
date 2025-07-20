namespace Deck_of_cards;

public class DeckFactory
{
    private static readonly string[] Suits = { "черви", "буба", "крести", "пика" };
    private static readonly string[] Ranks =
    {
        "двойка", "тройка", "четверка", "пятерка", "шестерка",
        "семерка", "восьмерка", "девятка", "десятка",
        "валет", "дама", "король", "туз"
    };

    public List<Card> CreateStandardDeck()
    {
        var cards = new List<Card>();

        foreach (string suit in Suits)
        {
            foreach (string rank in Ranks)
            {
                cards.Add(new Card(suit, rank));
            }
        }

        return cards;
    }
}