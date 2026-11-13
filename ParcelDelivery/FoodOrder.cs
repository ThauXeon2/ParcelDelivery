namespace ParcelDelivery;

public class FoodOrder : IDeliverable
{
    private string _restaurant;
    private string _address;

    public FoodOrder(string restaurant, string address)
    {
        Restaurant=restaurant;
        Address=address;
    }
    public string Restaurant{get => _restaurant;set=>_restaurant=value;}
    public string Address{get => _address;set=>_address=value;}
    public string GetAddress()=>Address;
    public string GetDescription() => $"Étel ({Restaurant}): {Address}";
}