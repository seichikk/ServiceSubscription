namespace SubscriptionService;

public class Program
{
    public static void Main(string[] args)
    {
        UserStorage userStorage = new UserStorage();

        Subscription freeSubscription = new Subscription(SubscriptionType.Free);
        Subscription standardSubscription = new Subscription(SubscriptionType.Standard);
        Subscription premiumSubscription = new Subscription(SubscriptionType.Premium);

        User user1 = new User("иван", freeSubscription, 1);
        User user2 = new User("олег", standardSubscription, 2);
        User user3 = new User("дима", premiumSubscription, 3);

        userStorage.Register(user1);
        userStorage.Register(user2);
        userStorage.Register(user3);

        Console.WriteLine($"всего юзеров: {userStorage.GetUsersCount()}");
        Console.WriteLine("активные подписчики: " + string.Join(", ", userStorage.GetActiveSubscribersNames()));
    }
}