namespace CheckoutModule.Services
{
    using SQLite;
    using Store.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ViewModels;

    public class ItemsService
    {
        private const string dbName = "Store.db";

        public ItemCollectionViewModel Items = new ItemCollectionViewModel();

        public async void GetItemsByCategory(string categoryName)
        {
            SQLiteAsyncConnection connection = new SQLiteAsyncConnection(dbName);
            var category = await connection.Table<Category>().Where(c => c.Name == categoryName).FirstOrDefaultAsync();
            IEnumerable<Item> data = await connection.Table<Item>().Where(i => i.CategoryId == category.Id).ToListAsync();

            if (data.Count() > 0)
            {
                data.ForEach(i => Items.Add(new ItemViewModel { Id = i.Id, Name = i.Name, Price = i.Price, Quantity = i.Quantity, Measurement = i.Measurement, ImageBytes = i.Image }));
            }
        }

        public async Task AddItemsAsync(Item item)
        {
            SQLiteAsyncConnection conn = new SQLiteAsyncConnection(dbName);
            await conn.InsertAsync(item);
        }

        public async Task SearchItemByNameAsync(string title)
        {
            SQLiteAsyncConnection conn = new SQLiteAsyncConnection(dbName);

            AsyncTableQuery<Item> query = conn.Table<Item>().Where(x => x.Name.Contains(title));
            List<Item> result = await query.ToListAsync();
            foreach (var item in result)
            {
                // ...
            }
        }

        public async Task UpdateItemQuantityAsync(int oldValue, int newValue)
        {
            SQLiteAsyncConnection conn = new SQLiteAsyncConnection(dbName);

            // Retrieve Article
            var item = await conn.Table<Item>()
                .Where(x => x.Quantity == oldValue).FirstOrDefaultAsync();
            if (item != null)
            {
                // Modify Article
                item.Quantity = newValue;

                // Update record
                await conn.UpdateAsync(item);
            }
        }

        public async Task DeleteItemAsync(int id)
        {
            SQLiteAsyncConnection conn = new SQLiteAsyncConnection(dbName);

            // Retrieve Article
            var item = await conn.Table<Item>().Where(x => x.Id == id).FirstOrDefaultAsync();
            if (item != null)
            {
                // Delete record
                await conn.DeleteAsync(item);
            }
        }
    }
}
