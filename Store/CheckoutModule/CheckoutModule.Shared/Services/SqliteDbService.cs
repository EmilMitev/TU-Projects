namespace CheckoutModule.Services
{
    using System;
    using System.IO;
    using SQLite;
    using Store.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Windows.Storage;

    public class SqliteDbService
    {
        private const string dbName = "Store.db";

        public async Task<bool> CheckDbAsync(string dbName)
        {
            bool dbExist = true;

            try
            {
                StorageFile sf = await ApplicationData.Current.LocalFolder.GetFileAsync(dbName);
            }
            catch (Exception)
            {
                dbExist = false;
            }

            return dbExist;
        }

        public async Task CreateDatabaseAsync()
        {
            SQLiteAsyncConnection conn = new SQLiteAsyncConnection(dbName);
            await conn.CreateTableAsync<Category>();
            await conn.CreateTableAsync<Item>();
        }

        public async Task AddItemsAndCategoriesAsync()
        {
            SQLiteAsyncConnection conn = new SQLiteAsyncConnection(dbName);

            var categories = new List<Category>()
            {
                new Category (){ Name = "Food" },
                new Category (){ Name = "Drink" },
                new Category (){ Name = "Style" }
            };

            await conn.InsertAllAsync(categories);

            var items = new List<Item>() {
                new Item()
                {
                    Id = 1,
                    Name = "Beef",
                    Price = 3.60m,
                    Measurement = "Kg.",
                    Quantity = 30,
                    CategoryId = 1
                },
                new Item()
                {
                    Id = 2,
                    Name = "Cheese",
                    Price = 2.40m,
                    Measurement = "Kg.",
                    Quantity = 24,
                    CategoryId = 1
                },
                new Item()
                {
                    Id = 3,
                    Name = "Potatoes",
                    Price = 1.00m,
                    Measurement = "Kg.",
                    Quantity = 1000,
                    CategoryId = 1
                },
                new Item()
                {
                    Id = 4,
                    Name = "Tomatoes",
                    Price = 0.80m,
                    Measurement = "Kg.",
                    Quantity = 200,
                    CategoryId = 1
                },
                new Item()
                {
                    Id = 1,
                    Name = "Coca Cola",
                    Price = 1.20m,
                    Measurement = "750ml.",
                    Quantity = 300,
                    CategoryId = 2
                },
                new Item()
                {
                    Id = 2,
                    Name = "Fanta",
                    Price = 1.40m,
                    Measurement = "600ml.",
                    Quantity = 400,
                    CategoryId = 2
                },
                new Item()
                {
                    Id = 3,
                    Name = "Juice",
                    Price = 0.80m,
                    Measurement = "1.2L.",
                    Quantity = 40,
                    CategoryId = 2
                },
                new Item()
                {
                    Id = 4,
                    Name = "Milk",
                    Price = 1.45m,
                    Measurement = "1.2L.",
                    Quantity = 50,
                    CategoryId = 2
                },
                new Item()
                {
                    Id = 1,
                    Name = "Nike Sports Man Trainers",
                    Price = 240.00m,
                    Measurement = "Item",
                    Quantity = 10,
                    CategoryId = 3
                }
            };

            await conn.InsertAllAsync(items);
        }

        public async Task DropTableAsync()
        {
            SQLiteAsyncConnection conn = new SQLiteAsyncConnection(dbName);
            await conn.DropTableAsync<Category>();
            await conn.DropTableAsync<Item>();
        }
    }
}
