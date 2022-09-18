using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogArticle.App
{
    public static class Actions
    {
        public static IMongoCollection<Article> ConectDB()
        {
            const string ConnectionString = "mongodb://localhost:27017";
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase("article_db");
            var colection = db.GetCollection<Article>("article");
            return colection;
        }
        public static void AddElementMongoDB(IMongoCollection<Article> colection, string title, string text)
        {
            colection.InsertOne(new Article { Title = title, Text = text });
        }
        public static void PrintMongoDB(IMongoCollection<Article> colection)
        {
            var blogArticle = colection.FindSync(new BsonDocument()).ToList();
            foreach (var item in blogArticle)
            {
                Console.WriteLine($"\t\t\tНазвание Блога : {item.Title}\n\t{item.Text}");
            }
        }
    }
}
