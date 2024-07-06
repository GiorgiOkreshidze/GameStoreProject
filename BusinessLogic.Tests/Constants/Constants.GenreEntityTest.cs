namespace BusinessLogicTests.Constants;

public class Constants_GenreEntityTest
{
    public static class GameEntityTest
    {
        public static readonly Guid Id = Guid.NewGuid();
        public const string Name = "Genre Name";
        public static readonly Guid? ParentGenreId = null;
        public const string GameName = "Game Name";
        public const string GameKey = "Game Key";
        public const string GameDescription = "Game Description";

        public static string GameNameFromIndex(int index) => $"{GameName} {index}";
        public static string GameKeyFromIndex(int index) => $"{GameKey} {index}";
        public static string GameDescriptionFromIndex(int index) => $"{GameDescription} {index}";
    }
}