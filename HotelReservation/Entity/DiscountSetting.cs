namespace HotelReservation.Entity;

public class DiscountSetting
{
    public Dictionary<Customer, int> VIPCustomersDiscount { get; private set; }
    public Dictionary<string, int> CodeDiscount { get; private set; }

    public DiscountSetting()
    {
        VIPCustomersDiscount = new Dictionary<Customer, int>
        {
            { new Customer("Pooya", "0902", "gmail"), 5 }
        };

        CodeDiscount = new Dictionary<string, int>
        {
            { "T1", 20 },
            { "T2", 10 }
        };
    }
}
