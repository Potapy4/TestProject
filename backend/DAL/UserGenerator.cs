using Bogus;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Generators
{
    public static class UserGenerator
    {
        private static readonly string[] Fruits = { "Banana", "Apple", "Lemon", "Orange", "Watermelon", "Grape", "Kiwi" };

        public static void Seed(this ModelBuilder modelBuilder)
        {
            Faker.GlobalUniqueIndex = 0;

            var testUsersFaker = new Faker<User>()
                .RuleFor(u => u.Id, f => f.UniqueIndex)
                .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName())
                .RuleFor(u => u.LastName, (f, u) => f.Name.LastName())
                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
                .RuleFor(u => u.AvatarUrl, f => f.Internet.Avatar());

            var testUsers = testUsersFaker.Generate(50);

            Faker.GlobalUniqueIndex = 0;

            var testOrdersFaker = new Faker<Order>()
            .RuleFor(o => o.Id, f => f.UniqueIndex)
            .RuleFor(o => o.Product, f => f.PickRandom(Fruits))
            .RuleFor(o => o.Quantity, f => f.Random.Number(1, 10))
            .RuleFor(o => o.UserId, f => f.PickRandom(testUsers).Id);

            var testOrders = testOrdersFaker.Generate(50);

            modelBuilder.Entity<Order>().HasData(testOrders);
            modelBuilder.Entity<User>().HasData(testUsers);
        }
    }
}
