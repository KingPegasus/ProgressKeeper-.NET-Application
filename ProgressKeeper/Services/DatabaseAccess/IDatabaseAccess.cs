using MongoDB.Bson;
using MongoDB.Driver;
using ProgressKeeper.DomainModels.Report;
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
        /// <param name="table">MongoDB Collection Name</param>
        /// <returns></returns>
        public Task WatchCollectionAsync<T>(string table);

        /// <summary>
        /// Insert Record in the collection(table)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table">MongoDB Collection Name</param>
        /// <param name="record"></param>
        public void InsertRecord<T>(string table, T record);

        /// <summary>
        /// Drop Table/Collection
        /// </summary>
        /// <param name="table"></param>
        public void DropCollection(string table);

        /// <summary>
        /// Get the Document filtered by Date.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table">MongoDB Collection Name</param>
        /// <param name="dateTime">Date to be used to filter Document</param>
        /// <returns></returns>
        public T GetDocumentByDate<T>(string table, DateTime dateTime);

        /// <summary>
        /// Updates signal Value of the Signal Message in MongoDB Document
        /// </summary>
        /// <param name="table">MongoDB Collection Name</param>
        /// <param name="record"></param>
        public UpdateResult UpdateSignalValue(string table, Record record);

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
