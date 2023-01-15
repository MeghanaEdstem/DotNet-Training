class FrenchDeck
{
    public List<Card> _cards;
    public FrenchDeck()
    {
        _cards = new List<Card>();
        string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        string[] suits = { "SPADES", "DIAMONDS", "CLUBS", "HEARTS" };
        foreach (string rank in ranks)
        {
            foreach (string suit in suits)
            {
                _cards.Add(new Card(rank, suit));
            }
        }
    }
    
    public void PrintDeck()
    {
        foreach (Card card in _cards)
        {
            card.PrintCard();
        }
    }
}