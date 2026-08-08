namespace SubscriptionService;

public class StandardUser : User
{
    public StandardUser(string name) : base(name)
    {
    }

    public override void WhoAmI()
    {
        Console.WriteLine($"я стандартный пользователь");
    }
}