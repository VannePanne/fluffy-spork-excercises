using System.ComponentModel.DataAnnotations;

namespace webapiDotNetTrainingGround.Models;

public class CreateDeveloperRequest
{
    [Required(ErrorMessage = "Name is required.")]
    [MinLength(2, ErrorMessage = "Name must be at least 2 characters.")]
    [MaxLength(100, ErrorMessage = "Name can be at most 100 characters.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "The 'Email' needs to be supplied in the request body.")]
    [EmailAddress(ErrorMessage = "Email must be a valid email address.")]
    [MaxLength(200, ErrorMessage = "Email can be at most 200 characters.")]
    public string? Email { get; set; }
}
