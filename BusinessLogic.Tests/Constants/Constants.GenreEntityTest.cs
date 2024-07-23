namespace BusinessLogicTests.Constants;

public static partial class Constants
{
    public static class GenreEntityTest
    {
        public const string Name = "Genre Name";
        public const string GameName = "Game Name";
        public const string GameKey = "Game Key";
        public const string GameDescription = "Game Description";

        public static readonly Guid Id = Guid.NewGuid();

        public static readonly Guid? ParentGenreId;

        public static string GameNameFromIndex(int index) => $"{GameName} {index}";

        public static string GameKeyFromIndex(int index) => $"{GameKey} {index}";

        public static string GameDescriptionFromIndex(int index) => $"{GameDescription} {index}";
    }
}