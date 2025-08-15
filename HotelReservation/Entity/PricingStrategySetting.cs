namespace HotelReservation.Entity;

public class PricingStrategySetting
{
    public Dictionary<IPricingStrategy, int> PricingStrategyPercent { get; private set; }

    public PricingStrategySetting()
    {
        PricingStrategyPercent = new Dictionary<IPricingStrategy, int>
        {
            { new HighSeasoningPricing(null), 10 },
            { new LowSeasoningPricing(null), 10 }
        };
    }
}
