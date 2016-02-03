namespace MyFirstMVC4Application.Migrations
{
    using MyFirstMVC4Application.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyFirstMVC4Application.Models.MyMVCDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MyFirstMVC4Application.Models.MyMVCDBContext";
        }

        protected override void Seed(MyFirstMVC4Application.Models.MyMVCDBContext context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { Name = "Simhapuri", City = "Nellore", Country = "India" },
                new Restaurant { Name = "Trump", City = "Chicago", Country = "US" },
                new Restaurant
                {
                    Name = "Hayat",
                    City = "New York",
                    Country = "US",
                    Reviews = new List<RestaurantReview> {
                        new RestaurantReview {Rating=1,  Body="Great Hospitaity with house keeping", ReviewerName="Srinivas"}
                        }
                });
            
        }
    }
}
