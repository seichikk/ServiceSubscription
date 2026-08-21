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
        userStorage.Register(new User("иван", new Subscription(SubscriptionType.Standard), 1));
        int newCount = userStorage.GetUsersCount();
        Assert.AreEqual(initialCount + 1, newCount);
    }

    [Test]
    public void GetPaidSubscribersNamesTest()
    {
        userStorage.Register(new User("иван", new Subscription(SubscriptionType.Standard), 1));
        userStorage.Register(new User("петр", new Subscription(SubscriptionType.Free), 2));
        userStorage.Register(new User("мария", new Subscription(SubscriptionType.Premium), 3));

        List<string> paidSubscribers = userStorage.GetPaidSubscribersNames();

        Assert.Contains("иван", paidSubscribers);
        Assert.Contains("мария", paidSubscribers);
        Assert.IsFalse(paidSubscribers.Contains("петр"));
    }

    [Test]
    public void GetUsersCountTest()
    {
        userStorage.Register(new User("иван", new Subscription(SubscriptionType.Standard), 1));
        userStorage.Register(new User("петр", new Subscription(SubscriptionType.Free), 2));
        userStorage.Register(new User("мария", new Subscription(SubscriptionType.Premium), 3));

        int count = userStorage.GetUsersCount();

        Assert.AreEqual(3, count);
    }
}