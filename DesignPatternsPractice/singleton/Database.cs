

class Database
{
    private static readonly Database databaseInstance = new Database();

    private Database()
    {
        // Private constructor to prevent instantiation from outside the class
    }

    public static Database instance
    {
        get
        {
            return databaseInstance;
        }
    }
}