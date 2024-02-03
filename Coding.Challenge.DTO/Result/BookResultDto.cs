namespace Coding.Challenge.DTO.Result;

public class BookResultDto
{
    public long CategoryId { get; set; }
    public string Category { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTimeOffset PublishDateUtc { get; set; }
}
