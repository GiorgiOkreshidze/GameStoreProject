namespace BusinessLogicTests.Constants;

public static partial class Constants
{
    public static class GameEntityTest
    {
        public const string Name = "Game Name";
        public const string Key = "Game Key";
        public const string Description = "Game Description";
        public const double Price = 5;
        public const int UnitInStock = 5;
        public const int Discount = 5;

        public const string CompanyName = "Publishers Company Name";
        public const string HomePage = "Publishers Home page";
        public const string PublisherDescription = "Publishers Description";

        public const string GenreName = "Genre Name";
        public const string PlatformType = "Platform Type";

        public static readonly Guid PublisherId = Guid.NewGuid();
        public static readonly Guid Id = Guid.NewGuid();

        public static string GenreNameFromIndex(int index) => $"{GenreName} {index}";

        public static string PlatformTypeFromIndex(int index) => $"{PlatformType} {index}";
    }
}