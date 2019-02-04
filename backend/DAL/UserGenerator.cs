using DAL.Models;
using Bogus;
using System.Linq;

namespace DAL.Generators
{
    public static class UserGenerator
    {
        private static readonly string[] Fruits = { "Banana", "Apple", "Lemon", "Orange", "Watermelon", "Grape", "Kiwi" };

        public static int GenerateUsers(UserDBContext context)
        {
            var testOrders = new Faker<Order>()
            .RuleFor(o => o.Product, f => f.PickRandom(Fruits))
            .RuleFor(o => o.Quantity, f => f.Random.Number(1, 10));

            var testUsers = new Faker<User>()
                .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName())
                .RuleFor(u => u.LastName, (f, u) => f.Name.LastName())
                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
                .RuleFor(u => u.AvatarUrl, f => f.Internet.Avatar())
                .RuleFor(u => u.Orders, f => testOrders.Generate(f.Random.Number(1, 10)).ToList());

            var data = testUsers.Generate(50);
            context.AddRange(data);
            context.SaveChanges();
            return data.Count;
        }
    }
}
