namespace BusinessLogic.Validations;

public interface IValidationsHandler
{
    public void ValidateGenres(ICollection<Guid> genreIds);

    public void ValidatePlatforms(ICollection<Guid> platformIds);

    public void ValidateGameId(Guid id);

    public void ValidateGameKey(string key);

    public void ValidatePublisherId(Guid? id);

    public void ValidatePlatform(Guid id);

    public void ValidatePlatformType(string type);

    public void ValidateGenre(Guid id);

    public void ValidateGenreName(string name);

    public void ValidateCompanyName(string companyName);
}