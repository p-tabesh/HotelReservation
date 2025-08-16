namespace HotelReservation.Discount.DiscountSetting;

public class CodeDiscountSetting : IDiscountSetting
{
    public Dictionary<string, int> CodeDiscounts { get; private set; }

    public CodeDiscountSetting()
    {
        CodeDiscounts = new Dictionary<string, int>
        {
            { "T1", 20 },
            { "T2", 10 }
        };
    }
}
