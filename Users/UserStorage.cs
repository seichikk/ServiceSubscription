namespace SubscriptionService;

public class UserStorage
{
    private List<User> _users = new List<User>();

    public void Register(User user)
    {
        _users.Add(user);
    }

    public int GetUsersCount()
    {
        return _users.Count;
    }

    public List<string> GetPaidSubscribersNames()
    {
        List<string> subscribedUsers = new List<string>();

        foreach (User user in _users)
        {
            if (user.UserSubscription.Type != SubscriptionType.Free)
            {
                subscribedUsers.Add(user.Name);
            }
        }

        return subscribedUsers;
    }

    public User? GetUserById(int id)
    {
        return _users.FirstOrDefault(u => u.Id == id);
    }
}