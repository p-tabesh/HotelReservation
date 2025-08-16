namespace HotelReservation.Entity.Pricing;

public class PricingStrategyCreator
{
    public PricingStrategyCreator()
    {

    }

    public IPricingStrategy Create() => new HighSeasoningPricing(new PricingStrategySetting());
}
