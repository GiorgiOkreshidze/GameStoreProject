#pragma warning disable IDE0005
using DTOs.GameDtos;
using DTOs.PublisherDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Contracts;

public interface IPublisherService
{
    public void CreatePublisher(CreatePublisherDto publisherDto);

    public GetPublisherDto GetPublisherByCompanyName(string companyName);

    public ICollection<GetPublisherDto> GetAllPublishers();

    public void UpdatePublisher(UpdatePublisherDto publisherDto);

    public void DeletePublisher(Guid id);

    public GetPublisherDto GetPublisherOfGame(string key);
}