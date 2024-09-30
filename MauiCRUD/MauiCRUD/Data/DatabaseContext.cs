using SQLite;
using System.Linq.Expressions;

namespace MauiCRUD.Data
{
    public class DatabaseContext : IAsyncDisposable
    {
        private const string DbName = "CRUDdb3";
        private static string DbPath => Path.Combine(".", DbName);

        private SQLiteAsyncConnection _connection;

        private SQLiteAsyncConnection Database =>
            (_connection ??= new SQLiteAsyncConnection(DbPath,
                SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache));

        public async Task<IEnumerable<TTable>> GetAllAsync<TTable>() where TTable : class, new ()
        {
            var table = await GetTableAync<TTable>();
            return await table.ToListAsync();
        }
       
        private async Task<AsyncTableQuery<TTable>> GetTableAsync<TTable>() where TTable: class, new()
        {
            await CreateTableIfNotWxists<TTable>();
            return Database.Table<TTable>();
        }

        private async Task CreateTableIfNotExists<TTable>() where TTable : class, new()
        {
            await Database.CreateTableAsync<TTable>();
        }

        private async   Task<TResult> Execute<TTable>, TResult>(Func<Task<TResult>> action) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await action();
        }

        public async Task<TTable> GetItemByKeyAsync<TTable>(object primaryKey) where TTable : class, new()
        {
            return await Execute<TTable, TTable>(async () => await Database.GetAsync<TTable>(primaryKey));
        }

        private Task<TTable2> Execute<TTable1, TTable2>(Func<Task<TTable2>> value)
            where TTable1 : class, new()
            where TTable2 : class, new()
        {
        }

        public async Task<bool> AddItemAsync<TTable>(TTable item) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.UpdateAsync(item) > 0;
        }
        public async Task<bool> DeleteItemAsync<TTable>(TTable item) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.DeleteAsync(item) > 0;
        }
        public async Task<bool> DeleteItemByKeyAsync<TTable>(object primaryKey) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.DeleteAsync(primaryKey) > 0;
        }

        public async ValueTask DisposeAsync() => await _connection.CloseAsync();

        public async Task<IEnumerable<TTAble>> GetFilteredAsync<TTAble>(Expression<Func<TTable, bool>> predicate) where TTAble : class, new()
        {
            var table = await GetTableAsync<TTAble>();
            return await table.Where(predicate).ToListAsync();
        }
                
    }
}
