public class ShoppingCart
{
    private readonly List<ShoppingCartEntry> _entries;
    public ShoppingCart()
    {
        _entries = new List<ShoppingCartEntry>();
    }
    public void AddToCart(ShoppingCartEntry items)
    {
        _entries.Add(items);
    }

    public double TotalAmount()
    {
        double total = 0.0;
        foreach (var item in _entries)
        {
            total += item.Price * item.Quantity;
        }
        return total;
    }
    public void PrintCart()
    {
        foreach (var item in _entries)
        {
            Console.WriteLine(item);
        }
    }
} 