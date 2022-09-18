using BlogArticle.App;

var colection = Actions.ConectDB();
Actions.PrintMongoDB(colection);
Actions.AddElementMongoDB(colection, "Title3", "Text3");
Console.WriteLine("================================================================");
Actions.PrintMongoDB(colection);