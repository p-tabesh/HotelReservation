namespace HotelReservation.Discount.DiscountSetting;

public class VIPCustomerDiscountSetting : IDiscountSetting
{
    public HashSet<string> VIPCustomers { get; private set; }
    public int DiscountPercent { get; private set; }
    public VIPCustomerDiscountSetting()
    {
        VIPCustomers = new HashSet<string>()
        {
            "09",
            "08"
        };

        DiscountPercent = 10;
    }
}
