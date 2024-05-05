using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAppMaui.Models
{
    public class DBController
    {
        private const string DB_NAME = "TaskManagerDB.db3";
        private readonly SQLiteAsyncConnection _connection;
        public DBController()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Note>();
        }
        public async Task<List<Note>> GetAllUsers()
        {
            return await _connection.Table<Note>().ToListAsync();
        }
        public async Task<Note> GetById(int id)
        {
            return await _connection.Table<Note>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        public async Task Create(Note note)
        {
            await _connection.InsertAsync(note);
        }
        public async Task Update(Note note)
        {
            await _connection.UpdateAsync(note);
        }
        public async Task Delete(Note note)
        {
            await _connection.DeleteAsync(note);
        }
    }
}
