using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using BusinessLogic.Validations;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.PublisherDtos;

namespace BusinessLogic.Services;

public class PublisherService(IPublisherDbService publisherDbService, IMapper publisherMapper, IValidationsHandler validator) : IPublisherService
{
    public void CreatePublisher(CreatePublisherDto publisherDto)
    {
        var publisher = publisherMapper.Map<CreatePublisherDto, Publisher>(publisherDto);
        
        publisher.Id = Guid.NewGuid();

        var publisherEntity = publisherMapper.Map<Publisher, PublisherEntity>(publisher);

        publisherDbService.CreatePublisherDb(publisherEntity);
    }

    public GetPublisherDto GetPublisherByCompanyName(string companyName)
    {
        validator.ValidateCompanyName(companyName);

        var publisherEntity = publisherDbService.GetPublisherByCompanyNameDb(companyName);

        var publisher = publisherMapper.Map<PublisherEntity, Publisher>(publisherEntity);
        var publisherDto = publisherMapper.Map<Publisher, GetPublisherDto>(publisher);

        return publisherDto;
    }

    public ICollection<GetPublisherDto> GetAllPublishers()
    {
        var publisherEntities = publisherDbService.GetAllPublishersDb();

        var publishers = publisherMapper.Map<ICollection<PublisherEntity>, ICollection<Publisher>>(publisherEntities);
        var publisherDtos = publisherMapper.Map<ICollection<Publisher>, ICollection<GetPublisherDto>>(publishers);

        return publisherDtos;
    }

    public void UpdatePublisher(UpdatePublisherDto publisherDto)
    {
        var publisher = publisherMapper.Map<UpdatePublisherDto, Publisher>(publisherDto);
        
        validator.ValidatePublisherId(publisher.Id);
        
        var publisherEntity = publisherMapper.Map<Publisher, PublisherEntity>(publisher);

        publisherDbService.UpdatePublisherDb(publisherEntity);
    }

    public void DeletePublisher(Guid id)
    {
        validator.ValidatePublisherId(id);

        publisherDbService.DeletePublisherDb(id);
    }

    public ICollection<GetGameDto> GetGamesOfPublisher(string companyName)
    {
        validator.ValidateCompanyName(companyName);

        var gameEntities = publisherDbService.GetGamesOfPublisherDb(companyName);

        var games = publisherMapper.Map<ICollection<GameEntity>, ICollection<Game>>(gameEntities);
        var gameDtos = publisherMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(games);

        return gameDtos;
    }
}