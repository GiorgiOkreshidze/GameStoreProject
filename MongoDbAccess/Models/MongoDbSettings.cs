namespace MongoDbAccess.Models;

public class MongoDbSettings
{
    public string ConnectionString { get; set; }

    public string DatabaseName { get; set; }

    public string ProductsCollectionName { get; set; }

    public string CategoriesCollectionName { get; set; }

    public string ShippersCollectionName { get; set; }

    public string OrdersCollectionName { get; set; }

    public string ChangeLogCollectionName { get; set; }

    public string SuppliersCollectionName { get; set; }
}