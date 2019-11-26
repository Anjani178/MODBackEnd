using System;
using System.Collections.Generic;
using System.Text;
using Assignment1.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Context
{
    class OrderContext:DbContext
    {
        public DbSet<Order> Order { get; set; }

        public DbSet<Item> Item { get; set; }


        //manage connection strings
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-MFOQ4PM\ANJANI;Database=School;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 1,
                IName = "Pen",
                Price = 10,
            },
            new Item
            {
                ItemId = 2,
                IName = "Watch",
                Price = 500.1,
            }
            );
            modelBuilder.Entity<Order>().HasData(new Order
            {
                OrderId = 1,
                OrderDate = DateTime.Now,
                DeliveryDate=DateTime.Now.AddDays(7),
                ItemId= 2

            },
            new Order
            {
                OrderId = 2,
                OrderDate = DateTime.Now,
                DeliveryDate = DateTime.Now.AddDays(7),
                ItemId = 1

            },
            new Order
            {
                OrderId = 3,
                OrderDate = DateTime.Now,
                DeliveryDate = DateTime.Now.AddDays(7),
                ItemId = 2

            });

        }
    }
}
