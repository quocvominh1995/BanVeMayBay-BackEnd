﻿namespace BanVeMayBay.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BanVeMayBay.DataContexts.AirticketDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BanVeMayBay.DataContexts.AirticketDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //var airport1 = new Airport { Code = "SGN", Name = "Sân bay quốc tế Tân Sơn Nhất" };
            //var airport2 = new Airport { Code = "HAN", Name = "Sân bay quốc tế Nội Bài" };
            //var airport3 = new Airport { Code = "PQC", Name = "Sân bay quốc tế Phú Quốc" };
            //var airport4 = new Airport { Code = "DAD", Name = "Sân bay quốc tế Đà Nẵng" };

            //context.Airport.Add(airport1);
            //context.Airport.Add(airport2);
            //context.Airport.Add(airport3);
            //context.Airport.Add(airport4);

            context.Users.AddOrUpdate(
                user => user.UserName,
                new User()
                {
                    UserName = "vominhquoc",
                    Id = Guid.NewGuid().ToString("N"),
                    PasswordHash = new PasswordHasher().HashPassword("user123456"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Email = "tugberk@example.com",
                    EmailConfirmed = true
                });
        }
    }
}
