using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogArticle.App
{
    public class Article
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("text")]
        public string Text { get; set; }
    }
}
