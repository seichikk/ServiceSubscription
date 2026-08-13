public class Subscription
{
    public SubscriptionType Type { get; private set; }
    public bool HasBetaAccess { get; private set; }

    public Subscription(SubscriptionType type)
    {
        Type = type;
        
        if (type == SubscriptionType.Premium)
        {
            HasBetaAccess = true;
        }
        else
        {
            HasBetaAccess = false;
        }
    }
}