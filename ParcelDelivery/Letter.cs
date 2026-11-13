namespace ParcelDelivery;

public class Letter : Parcel
{
    public Letter(string code, string address, int weightGrams) : base(code, address, weightGrams)
    {
    }

    public override int GetShippingFee() => 300;
}
