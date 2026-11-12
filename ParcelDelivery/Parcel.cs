namespace ParcelDelivery;

public abstract class Parcel : IDeliverable
{
    private string _code;
    private string address;
    private int _weightGrams;
    public string Code{get => _code; set => _code = value;}
    public string Address{get => address; set => address = value;}
    public int WeightGrams{get => _weightGrams; set => _weightGrams = (value >= 1 ? value : 1);}

    public Parcel(string code, string address, int weightGrams)
    {
        Code = code;
        Address = address;
        WeightGrams = weightGrams;
        _events = new();
    }
    public abstract int GetShippingFee();
    public virtual string GetDescription()=>$"{Code}{(Events.Count > 0 ? $" ({Events.Count} állapot):" : " :")} {Address}, {WeightGrams} g, {GetShippingFee()} Ft";
    public virtual bool CanGoInLocker()=> WeightGrams<=20000 ? true : false;
    public virtual string GetAddress()=> Address;
    private List<TrackingEvent> _events;
    public List<TrackingEvent> Events => _events;

    public TrackingEvent AddEvent(ParcelStatus status)
    {
        _events.Add(new TrackingEvent(status, this));
        return new TrackingEvent(status, this);
    }
}