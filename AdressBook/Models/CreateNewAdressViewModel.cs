using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AdressBook.Models;
public class CreateNewAdressViewModel
{
  [DisplayName("Owner name")]
  [Required]
  public string? Name { get; set; }

  [DisplayName("Street Name")]
  [Required]
  public string Street { get; set; }

  [DisplayName("City Name")]
  [Required]
  public string City { get; set; }

  [DisplayName("Email address")]
  [Required]
  [EmailAddress]
  public string? Email { get; set; }
}