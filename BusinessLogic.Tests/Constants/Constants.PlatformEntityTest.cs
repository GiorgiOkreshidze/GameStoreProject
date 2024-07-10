namespace BusinessLogicTests.Constants;

public static partial class ConstantsPlatform
{
    public static class PlatformEntityTest
    {
        public static readonly Guid Id = Guid.NewGuid();
        public const string Type = "Platform Type";
        public const string GameName = "Game Name";
        public const string GameKey = "Game Key";
        public const string GameDescription = "Game Description";

        public static string GameNameFromIndex(int index) => $"{GameName} {index}";
        public static string GameKeyFromIndex(int index) => $"{GameKey} {index}";
        public static string GameDescriptionFromIndex(int index) => $"{GameDescription} {index}";
    }
}