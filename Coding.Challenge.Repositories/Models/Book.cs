using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coding.Challenge.Repositories.Models;
internal class Book
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public long CategoryId { get; set; }

    [Required]
    [MaxLength(250)]
    public string Title { get; set; }

    [MaxLength(250)]
    public string Description { get; set; }

    [Required]
    public DateTimeOffset PublishDateUtc { get; set; }
}
