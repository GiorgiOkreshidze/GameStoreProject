namespace BusinessLogic.Contracts;

public interface IShipperService
{
    public ICollection<object> GetShippers();
}