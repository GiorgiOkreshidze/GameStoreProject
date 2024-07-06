namespace BusinessLogicTests.Constants;

public static partial class Constants
{
    public static class GameEntityTest
    {
        public static readonly Guid Id = Guid.NewGuid();
        public const string Name = "Game Name";
        public const string Key = "Game Key";
        public const string Description = "Game Description";
        public const string GenreName = "Genre Name";
        public const string PlatformType = "Platform Type";

        public static string GenreNameFromIndex(int index) => $"{GenreName} {index}";
        public static string PlatformTypeFromIndex(int index) => $"{PlatformType} {index}";
    }
}