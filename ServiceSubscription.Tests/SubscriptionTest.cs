using SubscriptionService;

namespace ServiceSubscription.Tests;

public class Tests
{
    private Subscription subscription;
    
    [SetUp]
    public void Setup()
    {
        subscription = new Subscription(SubscriptionType.Premium);
    }

    [Test]
    public void HasBetaAccessTest()
    {
       bool hasBetaAccess = subscription.HasBetaAccess;
       Assert.IsTrue(hasBetaAccess);
    }
}
