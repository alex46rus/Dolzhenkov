using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dolzhenkov.Models
{
    class TextdateBase
    {
        readonly SQLiteAsyncConnection database;

        public TextdateBase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Text>().Wait();
        }

        public Task<List<Text>> GetTextsAsync()
        {
            //Get all notes.
            return database.Table<Text>().ToListAsync();
        }

        public Task<Text> GetTextAsync(int id)
        {
            // Get a specific note.
            return database.Table<Text>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveTextAsync(Text note)
        {
            if (note.Id != 0)
            {
                // Update an existing note.
                return database.UpdateAsync(note);
            }
            else
            {
                // Save a new note.
                return database.InsertAsync(note);
            }
        }

        public Task<int> DeleteTextAsync(Text note)
        {
            // Delete a note.
            return database.DeleteAsync(note);
        }
    }
}
