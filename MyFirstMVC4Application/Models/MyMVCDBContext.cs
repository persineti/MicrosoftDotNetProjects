using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyFirstMVC4Application.Models
{
    public class MyMVCDBContext : DbContext
    {
        public MyMVCDBContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
    }
}