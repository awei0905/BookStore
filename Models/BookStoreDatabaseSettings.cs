namespace BookStoreApi.Models;

public class BookStoreDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
    public string BooksCollectionName { get; set; } = null!;
    public MongoCreds Creds { get; set; }
}

public class MongoCreds
{
    public string User { get; set; }
    public string Password { get; set; }
}