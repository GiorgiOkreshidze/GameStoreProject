using DataAccess.Contracts;
using Microsoft.AspNetCore.Http;

namespace BusinessLogic.Validations;

public class PublisherValidation(IHttpContextAccessor httpContextAccessor, IPublisherDbService publisherDbService) : Validator(httpContextAccessor)
{
    public void CanDeletePublisher(string publisherName)
    {
        if (publisherDbService.CompanyNameNotExists(publisherName))
        {
            throw new InvalidDataException("Publisher name does not exist");
        }
    }

    public void CanUpdatePublisher(string publisherName)
    {
        if (publisherDbService.CompanyNameNotExists(publisherName))
        {
            throw new InvalidDataException("Publisher name does not exist");
        }
    }

    public void CanAddPublisher(string publisherName)
    {
        if (!publisherDbService.CompanyNameNotExists(publisherName))
        {
            throw new InvalidDataException("Publisher name does not exist");
        }
    }
}