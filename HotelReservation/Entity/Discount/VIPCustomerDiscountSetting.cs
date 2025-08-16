namespace HotelReservation.Entity.Discount;

public class VIPCustomerDiscountSetting:IDiscountSetting
{
    public Dictionary<Customer, int> VIPCustomersDiscount { get; private set; }

    public VIPCustomerDiscountSetting()
    {
        
    }
}
