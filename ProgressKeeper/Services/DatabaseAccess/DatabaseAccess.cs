using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ProgressKeeper.Services.DatabaseAccess
{
    public class DatabaseAccess : IDatabaseAccess
    {
        private IMongoDatabase _db;
        static private MongoClient _client;
        private IDatabaseAccess.UpdateReceiveCallback updateReceiveCallback;

        /// <summary>
        /// Constructor
        /// </summary>
        public DatabaseAccess()
        {
            _client = new MongoClient();
        }

        /// <summary>
        /// Get Database
        /// </summary>
        /// <param name="database"></param>
        public void GetDatabase(string database)
        {
            try
            {
                _db = _client.GetDatabase(database);
            }
            catch (Exception e)
            {
                throw new Exception($"GetDatabase: Failed to Fetch Database. Internal Error: {e}");
            }
        }

        /// <summary>
        /// Checks if Database is null
        /// </summary>
        /// <param name="database"></param>
        /// <returns></returns>
        public bool IsDatabaseNull(string database)
        {
            if (_db == null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Drop Table/Collection
        /// </summary>
        /// <param name="table"></param>
        public void DropCollection(string table)
        {
            try
            {
                _db.DropCollection(table);
            }
            catch (Exception e)
            {
                throw new Exception($"DropCollection: Failed to drop collection. Internal Error: {e}");
            }

        }

        /// <summary>
        /// Insert Record in the collection(table)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <param name="record"></param>
        public void InsertRecord<T>(string table, T record)
        {
            try
            {
                var collection = _db.GetCollection<T>(table);
                collection.InsertOne(record);
            }
            catch (Exception e)
            {
                throw new Exception($"InsertRecord: Failed to Insert collection. Internal Error: {e}");
            }
        }

        /// <summary>
        /// Watches the update in database collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public async Task WatchCollectionAsync<T>(string table)
        {
            var collection = _db.GetCollection<T>(table);
            var update = String.Empty;

            using var cursor = await collection.WatchAsync();
            await cursor.ForEachAsync(change =>
            {
                // Action on change event

                // Extract Update
                try
                {
                    update = change.UpdateDescription.UpdatedFields.ToString();
                }
                catch (Exception e)
                {
                    throw new Exception($"WatchCollectionAsync: Unable to retrive DB update. Exception: {e}");
                }

                // UpdateCallback function
                try
                {
                    updateReceiveCallback(update);
                }
                catch (Exception e)
                {
                    throw new Exception($"WatchCollectionAsync: Failed to execute updateReceiveCallback. Exception: {e}");
                }

            });
        }

        /// <summary>
        /// Add data recieve callback.
        /// </summary>
        /// <param name="callback"></param>
        public void AddCallback(IDatabaseAccess.UpdateReceiveCallback callback)
        {
            updateReceiveCallback = callback;
        }
    }
}
