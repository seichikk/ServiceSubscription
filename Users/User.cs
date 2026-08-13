namespace SubscriptionService;

public class User
{
    public string Name { get; private set; }
    public Subscription UserSubscription { get; private set; }

    public User(string name, Subscription subscription)
    {
        Name = name;
        UserSubscription = subscription;
    }
}