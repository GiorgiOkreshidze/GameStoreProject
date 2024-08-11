using System.Globalization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAccess.Models;

public class OrderDocument
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public int OrderID { get; set; }

    public string CustomerID { get; set; }

    public int EmployeeID { get; set; }

    [BsonIgnore]
    public DateTime OrderDate
    {
        get => DateTime.Parse(OrderDateString, null, DateTimeStyles.RoundtripKind);
        set => OrderDateString = value.ToString("o", CultureInfo.InvariantCulture);
    }

    [BsonIgnore]
    public DateTime RequiredDate
    {
        get => DateTime.Parse(RequiredDateString, null, DateTimeStyles.RoundtripKind);
        set => RequiredDateString = value.ToString("o", CultureInfo.InvariantCulture);
    }

    [BsonIgnore]
    public DateTime ShippedDate
    {
        get => DateTime.Parse(ShippedDateString, null, DateTimeStyles.RoundtripKind);
        set => ShippedDateString = value.ToString("o", CultureInfo.InvariantCulture);
    }

    public int ShipVia { get; set; }

    public decimal Freight { get; set; }

    public string ShipName { get; set; }

    [BsonIgnore]
    public string ShipAddress
    {
        get => ShipAddressValue.IsString ? ShipAddressValue.AsString : ShipAddressValue.ToString();
        set => ShipAddressValue = new BsonString(value);
    }

    [BsonIgnore]
    public string ShipCity
    {
        get => ShipCityValue.IsString ? ShipCityValue.AsString : ShipCityValue.ToString();
        set => ShipCityValue = new BsonString(value);
    }

    public string ShipRegion { get; set; }

    [BsonIgnore]
    public string ShipPostalCode
    {
        get => ShipPostalCodeValue.IsString ? ShipPostalCodeValue.AsString : ShipPostalCodeValue.ToString();
        set => ShipPostalCodeValue = new BsonString(value);
    }

    [BsonIgnore]
    public string ShipCountry
    {
        get => ShipCountryValue.IsString ? ShipCountryValue.AsString : ShipCountryValue.ToString();
        set => ShipCountryValue = new BsonString(value);
    }

    [BsonElement("field14")]
    [BsonIgnoreIfNull]
    public string Field14 { get; set; }

    [BsonElement("ShipAddress")]
    public BsonValue ShipAddressValue { get; set; }

    [BsonElement("ShipCity")]
    public BsonValue ShipCityValue { get; set; }

    [BsonElement("ShipPostalCode")]
    public BsonValue ShipPostalCodeValue { get; set; }

    [BsonElement("ShipCountry")]
    public BsonValue ShipCountryValue { get; set; }

    [BsonElement("OrderDate")]
    public string OrderDateString { get; set; }

    [BsonElement("RequiredDate")]
    public string RequiredDateString { get; set; }

    [BsonElement("ShippedDate")]
    public string ShippedDateString { get; set; }
}