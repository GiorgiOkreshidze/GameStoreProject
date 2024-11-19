using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAccess.Models;

public class SupplierDocument
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public int SupplierID { get; set; }

    public string CompanyName { get; set; }

    public string ContactName { get; set; }

    public string ContactTitle { get; set; }

    [BsonIgnore]
    public string Address
    {
        get => AddressValue.IsString ? AddressValue.AsString : AddressValue.ToString();
        set => AddressValue = new BsonString(value);
    }

    [BsonElement("Address")]
    public BsonValue AddressValue { get; set; }

    [BsonIgnore]
    public string City
    {
        get => CityValue.IsString ? CityValue.AsString : CityValue.ToString();
        set => CityValue = new BsonString(value);
    }

    [BsonElement("City")]
    public BsonValue CityValue { get; set; }

    public string Region { get; set; }

    [BsonIgnore]
    public string PostalCode
    {
        get => PostalCodeValue.IsString ? PostalCodeValue.AsString : PostalCodeValue.ToString();
        set => PostalCodeValue = new BsonString(value);
    }

    [BsonElement("PostalCode")]
    public BsonValue PostalCodeValue { get; set; }

    [BsonIgnore]
    public string Country
    {
        get => CountryValue.IsString ? CountryValue.AsString : CountryValue.ToString();
        set => CountryValue = new BsonString(value);
    }

    [BsonElement("Country")]
    public BsonValue CountryValue { get; set; }

    [BsonIgnore]
    public string Phone
    {
        get => PhoneValue.IsString ? PhoneValue.AsString : PhoneValue.ToString();
        set => PhoneValue = new BsonString(value);
    }

    [BsonElement("Phone")]
    public BsonValue PhoneValue { get; set; }

    [BsonIgnore]
    public string Fax
    {
        get => FaxValue.IsString ? FaxValue.AsString : FaxValue.ToString();
        set => FaxValue = new BsonString(value);
    }

    [BsonElement("Fax")]
    public BsonValue FaxValue { get; set; }

    public string HomePage { get; set; }

    [BsonElement("field12")]
    [BsonIgnoreIfNull]
    public string Field12 { get; set; }
}