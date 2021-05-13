using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressKeeper.DomainModels.Report
{
    [BsonIgnoreExtraElements]
    public class Record
    {

        /// <summary>
        /// The progress of the day.
        /// </summary>
        public string Progress { get; set; }

        /// <summary>
        /// The date of work.
        /// </summary>
        public DateTime WorkDate { get; set; }
    }
}
