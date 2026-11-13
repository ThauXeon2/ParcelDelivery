namespace ParcelDelivery;

public class Box : Parcel
{
    private int _longestSideCm;
    public int LongestSideCm{get=>_longestSideCm;set=>_longestSideCm=value>0 ? value : 0;}

    public Box(string code, string address, int weightGrams, int longestSideCm) : base(code, address, weightGrams)
    {
        LongestSideCm=longestSideCm;
    }
    public override int GetShippingFee()=>LongestSideCm>60 || WeightGrams>5000 ? 2400 : 1200;
    public override string GetDescription() => base.GetDescription()+$", {LongestSideCm} cm";
    public override bool CanGoInLocker()=>base.CanGoInLocker()&&LongestSideCm<=60;
}