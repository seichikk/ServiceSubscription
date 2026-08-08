namespace SubscriptionService;

public class FreeUser : User
{
    public FreeUser(string name) : base(name)
    {
    }

    public override void WhoAmI()
    {
        Console.WriteLine($"я бесплатный пользователь");
    }
}