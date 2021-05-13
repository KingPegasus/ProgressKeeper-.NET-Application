using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProgressKeeper.Services.DatabaseAccess
{
    public interface IDatabaseAccess
    {

        /// <summary>
        /// Get Database
        /// </summary>
        /// <param name="database"></param>
        public void GetDatabase(string database);

        /// <summary>
        /// Checks if Database is null
        /// </summary>
        /// <param name="database"></param>
        /// <returns></returns>
        public bool IsDatabaseNull(string database);

        /// <summary>
        /// Watches the update in database collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public Task WatchCollectionAsync<T>(string table);

        /// <summary>
        /// Insert Record in the collection(table)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <param name="record"></param>
        public void InsertRecord<T>(string table, T record);

        /// <summary>
        /// Drop Table/Collection
        /// </summary>
        /// <param name="table"></param>
        public void DropCollection(string table);

        /// <summary>
        /// Add Update receive callback
        /// </summary>
        /// <param name="callback"></param>
        public void AddCallback(UpdateReceiveCallback callback);

        /// <summary>
        /// Delegate for update received callback. Passes received data as string to the function.
        /// </summary>
        /// <param name="data">Data received by socket</param>
        public delegate void UpdateReceiveCallback(string data);
    }
}
