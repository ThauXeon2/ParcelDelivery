namespace ParcelDelivery;

class Program
{
    static void Main(string[] args)
    {
        Letter letter = new("L100", "Budapest, Fő utca 1.", 40);
        Pallet pallet = new("P300", "Győr, Ipari park 7.", 250000);
        Console.WriteLine($"{letter.GetDescription()} + {letter.CanGoInLocker()}");
        Console.WriteLine($"{pallet.GetDescription()} - {pallet.CanGoInLocker()}");
        Box box = new("B200", "Szeged, Kossuth utca 3.", 3500, 45);
        Box box2 = new("B201", "Pécs, Széchenyi tér 2.", 2000, 80);
        Console.WriteLine($"{box.GetShippingFee()} {box2.GetShippingFee()}");
        Console.WriteLine($"{box.CanGoInLocker()} {box2.CanGoInLocker()}");
        FoodOrder foodOrder = new("Pizzéria Roma","Budapest, Fő utca 1.");
        CourierRoute route = new();
        route.AddStop(foodOrder);
        route.AddStop(letter);
        route.AddStop(box);
        route.Stops.ForEach(x=>Console.WriteLine($"{x.GetAddress()},{x.GetDescription()}"));
        Console.WriteLine(route.CountAddresses());
        box.AddEvent(ParcelStatus.Posted);
        box.AddEvent(ParcelStatus.InTransit);
        box.Events.ForEach(x=>Console.WriteLine($"{x.GetDescription()}"));
        Console.WriteLine(box.GetDescription());

    }
}