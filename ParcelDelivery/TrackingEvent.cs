namespace ParcelDelivery;

public class TrackingEvent
{
    private ParcelStatus _status;
    private Parcel _parcel;
    public ParcelStatus Status{get=>_status;set=>_status=value;}
    public Parcel Parcel=>_parcel;

    public TrackingEvent(ParcelStatus status, Parcel parcel)
    {
        Status = status;
        _parcel = parcel;
    }
    //Az egysoros démon újra lecsap, csak 3db if statement.
    public string GetDescription()=>Parcel.Code+(Status==ParcelStatus.Posted ? ", feladva" : (Status==ParcelStatus.InTransit ? ", kiszállítás alatt" : ", kézbesítve"));
}