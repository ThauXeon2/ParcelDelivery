namespace ParcelDelivery;

public class Pallet : Parcel
{
    public Pallet(string code, string address, int weightGrams) : base(code, address, weightGrams)
    {
    }

    public override int GetShippingFee() => 8000 + (int)(WeightGrams / 1000) * 30;

    public override bool CanGoInLocker() => false;
}
