using System.ComponentModel.DataAnnotations;

namespace webapiDotNetTrainingGround.Models;

public class CreateDeveloperRequest
{
    [Required]
    public string? Name { get; set; } = default!;
    [Required]
    public string? Email { get; set; } = default!;
}
