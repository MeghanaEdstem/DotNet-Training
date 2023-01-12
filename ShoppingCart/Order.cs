class Order
{
    private double _tax = 0.02;
    public double GetTotalPrice(double addPrice)
    {
        double totalAmount = addPrice + addPrice * _tax;
        return totalAmount;
    }
}