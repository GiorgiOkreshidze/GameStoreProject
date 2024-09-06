using Microsoft.AspNetCore.Mvc;

namespace DTOs.GameDtos;

public class GameFilterDto
{
    public List<Guid>? Genres { get; set; }

    public List<Guid>? Platforms { get; set; }

    public List<Guid>? Publishers { get; set; }

    public double? MinPrice { get; set; }

    public double? MaxPrice { get; set; }

    public string? Name { get; set; }

    public string? PublishDateRange { get; set; }

    public string? Sort { get; set; }

    public int Page { get; set; }

    [ModelBinder(BinderType = typeof(IntBinder))]
    public int PageCount { get; set; }
}