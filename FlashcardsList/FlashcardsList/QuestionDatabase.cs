using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace FlashcardsList
{
    public class QuetionDatabase
    {
        readonly SQLiteAsyncConnection database;

        public TodoItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Card>().Wait();
        }

        public Task<List<Card>> GetItemsAsync()
        {
            return database.Table<Card>().ToListAsync();
        }


    }
}

