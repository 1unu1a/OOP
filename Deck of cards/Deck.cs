namespace Deck_of_cards;

public class Deck
{
    private List<Card> cards;
    private Random random = new Random();

    public Deck()
    {
        cards = new List<Card>();
        string[] suits = { "черви", "буба", "крести", "пика" };
        string[] ranks = {
            "двойка", "тройка", "четверка", "пятерка", "шестерка", "семерка", "восьмерка", "девятка", "десятка",
            "валет", "дама", "король", "туз"
        };

        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                cards.Add(new Card(suit, rank));
            }
        }
    }

    public Card DrawCard()
    {
        if (cards.Count == 0)
        {
            return null;
        }

        int index = random.Next(cards.Count);
        Card drawn = cards[index];
        cards.RemoveAt(index);
        return drawn;
    }

    public int CardsLeft
    {
        get { return cards.Count; }
    }

}