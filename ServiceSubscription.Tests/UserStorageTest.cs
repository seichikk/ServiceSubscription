using SubscriptionService;

namespace ServiceSubscription.Tests;

public class UserStorageTests
{
    private UserStorage userStorage;
    
    [SetUp]
    public void Setup()
    {
        userStorage = new UserStorage();
    }

    [Test]
    public void RegisterTest()
    {
        int initialCount = userStorage.GetUsersCount();
        userStorage.Register(new User("иван", new Subscription(SubscriptionType.Standard)));
        int newCount = userStorage.GetUsersCount();
        Assert.AreEqual(initialCount + 1, newCount);
    }

    [Test]
    public void GetActiveSubscribersNamesTest()
    {
        userStorage.Register(new User("иван", new Subscription(SubscriptionType.Standard)));
        userStorage.Register(new User("петр", new Subscription(SubscriptionType.Free)));
        userStorage.Register(new User("мария", new Subscription(SubscriptionType.Premium)));

        List<string> activeSubscribers = userStorage.GetActiveSubscribersNames();

        Assert.Contains("иван", activeSubscribers);
        Assert.Contains("мария", activeSubscribers);
        Assert.IsFalse(activeSubscribers.Contains("петр"));
    }

    [Test]
    public void GetUsersCountTest()
    {
        userStorage.Register(new User("иван", new Subscription(SubscriptionType.Standard)));
        userStorage.Register(new User("петр", new Subscription(SubscriptionType.Free)));
        userStorage.Register(new User("мария", new Subscription(SubscriptionType.Premium)));

        int count = userStorage.GetUsersCount();

        Assert.AreEqual(3, count);
    }
}