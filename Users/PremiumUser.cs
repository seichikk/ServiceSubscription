namespace SubscriptionService;

public class PremiumUser : User
{
    public PremiumUser(string name) : base(name)
    {
    }

    public override void WhoAmI()
    {
        Console.WriteLine($"я премиум пользователь");
    }

    public void AccessPremiumContent()
    {
        Console.WriteLine("у вас есть доступ к премиум контенту");
    }
}