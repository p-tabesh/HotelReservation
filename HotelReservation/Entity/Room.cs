namespace HotelReservation.Entity;

public class Room
{
    public int Number { get; private set; }
    public decimal Price { get; private set; }
    public RoomType Type { get; private set; }
    public int Capacity { get; private set; }
}

public enum RoomType
{
    Sweet,
    OneBed,
    TwoBed
}
