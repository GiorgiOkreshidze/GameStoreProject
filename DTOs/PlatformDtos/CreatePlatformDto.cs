namespace DTOs.PlatformDtos;

public class CreatePlatformDto
{
    public PPlatformDto Platform { get; set; }
}

#pragma warning disable SA1402
public class PPlatformDto
#pragma warning restore SA1402
{
    public string Type { get; set; }
}