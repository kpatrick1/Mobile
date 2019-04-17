using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using FlashcardsListDb.Model;



namespace FlashcardsListDb
{
    public class QuestionDb
    {
        readonly SQLiteAsyncConnection database;

        public QuestionDb(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Card>().Wait();
        }

        public Task<List<Card>> GetItemsAsync()
        {
            return database.QueryAsync<Card>("SELECT * FROM [Card]");

        }

        public Task<List<Card>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Card>("SELECT * FROM [Card] WHERE [Done] = 0 ORDER BY [Priority] DESC");
        }

        public Task<Card> GetItemAsync(int id)
        {
            return database.Table<Card>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Card item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Card item)
        {
            return database.DeleteAsync(item);
        }
    }
}

