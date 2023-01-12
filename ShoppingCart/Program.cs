string productName = string.Empty;
int quantity = 0;
double price = 0.0;

var shoppingCart = new ShoppingCart();

try
{
    for (int i = 0; i < 2; i++)
    {
        Console.Write("ADD YOUR PRODUCT NAME : ");
        productName = Convert.ToString(Console.ReadLine());

        Console.Write("ADD YOUR PRODUCT QUANTITY : ");
        quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("ADD YOUR PRODUCT PRICE : ");
        price = Convert.ToDouble(Console.ReadLine());

        var items = new ShoppingCartEntry(productName, quantity, price);
        shoppingCart.AddToCart(items);
    }

    Console.WriteLine("CART ITEMS");
    shoppingCart.PrintCart();


    Order order = new Order();
    double totalAmount = shoppingCart.TotalAmount();
    Console.WriteLine($"TOTAL AMOUNT :{order.GetTotalPrice(totalAmount)}");
}
catch (Exception ex)
{
    Console.WriteLine("INVALID FORMAT");
}

