using DTOs.GameDtos;
using DTOs.PublisherDtos;

namespace BusinessLogic.Contracts;

public interface IPublisherService
{
    public void CreatePublisher(CreatePublisherDto publisherDto);

    public GetPublisherDto GetPublisherByCompanyName(string companyName);

    public ICollection<GetPublisherDto> GetAllPublishers();

    public void UpdatePublisher(UpdatePublisherDto publisherDto);

    public void DeletePublisher(Guid id);

    public ICollection<GetGameDto> GetGamesOfPublisher(string companyName);
}