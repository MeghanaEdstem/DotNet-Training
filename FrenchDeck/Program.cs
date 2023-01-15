// French Deck

//class Program
//{
//    static void Main()
//    {
//        FrenchDeck deck = new FrenchDeck();
//        Console.WriteLine("Original Deck:");
//        deck.PrintDeck();
//        Console.WriteLine("Shuffled Deck:");
//        deck.Shuffle();
//        deck.PrintDeck();
//        Console.WriteLine("Sorted Deck:");
//        deck.SortDeck();
//        deck.PrintDeck();
//        Console.WriteLine("Random Card:");
//        Card randomCard = deck.PickRandomCard();
//        randomCard.PrintCard();
//    }
//}

using FrenchDeck;

var deck = new Deck();
Console.WriteLine("---------- Deck          ----------");
deck.Print();
Console.WriteLine("---------- Random Card   ----------");
var c1 = deck.RandomCard();
var c2 = deck.RandomCard();
Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine("---------- Shuffle Cards ----------");
deck.ShuffleCards();
deck.Print();
//// Debug to compare cards
c1 = new Card(Deck.Ranks[0], Suite.Clubs);
c2 = new Card(Deck.Ranks[12], Suite.Spades);
var compare = new CardComparator();
compare.Compare(c1, c2);
Console.WriteLine("---------- Sort Deck ----------");
deck.SortDeck();
deck.Print();