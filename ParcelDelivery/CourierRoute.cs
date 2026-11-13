namespace ParcelDelivery;

public class CourierRoute()
{
    private List<IDeliverable> _stops=new();
    public List<IDeliverable> Stops => _stops;
    public void AddStop(IDeliverable item)=>_stops.Add(item);
    public List<string> Addresses=>_stops.Select(x=>x.GetAddress()).Distinct().ToList();
    public int CountAddresses()=>Addresses.Count;
}