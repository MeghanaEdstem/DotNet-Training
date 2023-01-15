//class FrenchDeck
//{
//    public List<Card> Cards { get; set; }
//    public FrenchDeck()
//    {
//        Cards = new List<Card>();
//        string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
//        string[] suits = { "spades", "diamonds", "clubs", "hearts" };
//        foreach (string rank in ranks)
//        {
//            foreach (string suit in suits)
//            {
//                Cards.Add(new Card(rank, suit));
//            }
//        }
//    }
//    public void Shuffle()
//    {
//        Random rand = new Random();
//        for (int i = 0; i < Cards.Count; i++)
//        {
//            int randomIndex = rand.Next(i, Cards.Count);
//            Card temp = Cards[i];
//            Cards[i] = Cards[randomIndex];
//            Cards[randomIndex] = temp;
//        }
//    }
//    public void PrintDeck()
//    {
//        foreach (Card card in Cards)
//        {
//            card.PrintCard();
//        }
//    }
//    public Card PickRandomCard()
//    {
//        Random rand = new Random();
//        int randomIndex = rand.Next(0, Cards.Count);
//        return Cards[randomIndex];
//    }
//    public void SortDeck()
//    {
//        Cards = Cards.OrderByDescending(card => card.Rank)
//                     .ThenBy(card => card.Suit == "spades")
//                     .ThenBy(card => card.Suit == "hearts")
//                     .ThenBy(card => card.Suit == "diamonds")
//                     .ThenBy(card => card.Suit == "clubs")
//                     .ToList();
//    }
//}

namespace FrenchDeck;

public class Deck
{
    private readonly List<Card> _cards = new List<Card>(52);
    private static readonly Random Random = new Random();

    static Deck()
    {
        Ranks = Enumerable.Range(2, 9)
            .Select(n => n.ToString())
            .ToList();
        Ranks.AddRange(new[] { "J", "Q", "K", "A" });
    }

    // default constructor
    public Deck()
    {
        var suites = Enum.GetValues<Suite>();

        foreach (var t in suites)
        {
            foreach (var r in Ranks)
            {
                _cards.Add(new Card(r, t));
            }
        }
    }

    public List<Card> Cards => _cards;
    public static List<string> Ranks { get; }

    public void Print()
    {
        foreach (var card in _cards)
        {
            Console.WriteLine(card);
        }
    }

    public Card RandomCard()
    {
        return _cards[Random.Next(_cards.Count)];
    }

    public void ShuffleCards()
    {
        // Fischer-Yates shuffle algorithm
        var n = _cards.Count;
        while (n > 1)
        {
            n--;
            var k = Random.Next(n + 1);
            (_cards[k], _cards[n]) = (_cards[n], _cards[k]);
        }
    }

    public void SortDeck()
    {
        _cards.Sort(new CardComparator());
    }

}