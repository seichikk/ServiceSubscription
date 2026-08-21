using System;
using SubscriptionService;

namespace SubscriptionService;

public class Program
{
    public static void Main(string[] args)
    {
        UserStorage userStorage = new UserStorage();
        int currentId = 1;

        while (true)
        {
            Console.WriteLine("введите имя или 'выход':");
            string name = Console.ReadLine() ?? string.Empty;
            
            if (name?.ToLower() == "выход")
            {
                break;
            }

            Console.WriteLine("тип подписки 0 - Free, 1 - Standard, 2 - Premium:");
            string typeInput = Console.ReadLine() ?? string.Empty;
            
            if (Enum.TryParse(typeInput, out SubscriptionType type))
            {
                Subscription subscription = new Subscription(type);
                User user = new User(name ?? string.Empty, subscription, currentId++);
                userStorage.Register(user);
                Console.WriteLine("пользователь добавлен");
            }
            else
            {
                Console.WriteLine("неверный ввод");
            }
        }

        Console.WriteLine($"всего юзеров: {userStorage.GetUsersCount()}");
        Console.WriteLine("оплаченные подписчики: " + string.Join(", ", userStorage.GetPaidSubscribersNames()));
    }
}