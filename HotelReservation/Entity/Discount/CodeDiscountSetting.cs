
namespace HotelReservation.Entity.Discount;

public class CodeDiscountSetting : IDiscountSetting
{
    public Dictionary<Customer, int> VIPCustomersDiscount { get; private set; }
    public Dictionary<string, int> CodeDiscounts { get; private set; }

    public CodeDiscountSetting()
    {
        VIPCustomersDiscount = new Dictionary<Customer, int>
        {
            { new Customer("Pooya", "0902", "gmail"), 5 }
        };

        CodeDiscounts = new Dictionary<string, int>
        {
            { "T1", 20 },
            { "T2", 10 }
        };
    }
}
