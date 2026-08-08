namespace SubscriptionService;

public abstract class User
{
    public string Name { get; private set; }

    public User(string name)
    {
        Name = name;
    }

    public abstract void WhoAmI();
}