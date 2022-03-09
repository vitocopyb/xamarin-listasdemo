using ListasDemoApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListasDemoApp.Data
{
    public class FriendDatabase
    {
        private readonly SQLiteAsyncConnection database;

        public FriendDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Friend>().Wait();
        }

        public async Task<List<Friend>> GetItemsAsync()
        {
            return await database.Table<Friend>().ToListAsync();
        }

        public async Task<Friend> GetItemAsync(int id)
        {
            return await database.Table<Friend>()
                    .Where(i => i.ID == id)
                    .FirstOrDefaultAsync();
        }

        public async Task<int> SaveItemAsync(Friend item)
        {
            // si el registro existe, lo actualiza
            if (item.ID != 0)
            {
                return await database.UpdateAsync(item);
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }

        public async Task<int> DeleteItemAsync(Friend item)
        {
            return await database.DeleteAsync(item);
        }
    }
}
