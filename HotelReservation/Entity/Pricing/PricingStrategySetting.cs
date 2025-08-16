namespace HotelReservation.Entity.Pricing;

public class PricingStrategySetting
{
    public Dictionary<string, int> PricingStrategyPercent { get; private set; }

    public PricingStrategySetting()
    {
        PricingStrategyPercent = new Dictionary<string, int>
        {
            { nameof(HighSeasoningPricing), 10 },
            { nameof(LowSeasoningPricing), 10 }
        };
    }
}
