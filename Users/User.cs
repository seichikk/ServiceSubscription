namespace SubscriptionService;

public class User
{
    public string Name { get; private set; }
    public Subscription UserSubscription { get; private set; }
    public int Id { get; private set; }

    public User(string name, Subscription subscription, int id = 0)
    {
        Name = name;
        UserSubscription = subscription;
        Id = id;
    }
}