using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactsManager.Core.Domain.Entities;

public class Person
{
    [Key]
    public Guid PersonId { get; set; }

    [StringLength(40)]
    public string? Name { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    public DateTime? DateOfBirth { get; set; }
    public string? Gender { get; set; }
    public Guid? CountryId { get; set; }

    [StringLength(200)]
    public string? Address { get; set; }

    public bool ReceiveNewsLetter { get; set; }

    public string? TFN { get; set; }

    [ForeignKey("CountryId")]
    public Country? Country { get; set; }
}
