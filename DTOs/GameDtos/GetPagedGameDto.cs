using X.PagedList;

namespace DTOs.GameDtos;

public class GetPagedGameDto
{
    public IPagedList<GameDtoWithId> Games { get; set; }

    public int TotalPages { get; set; }

    public int CurrentPage { get; set; }
}