using System.ComponentModel.DataAnnotations;

namespace Pupper.Models
{
  public class Doggo
  {
    public int DoggoId { get; set; }
    [Required]
    [StringLength(20, ErrorMessage = "Sorry this Doggos name can be longer than 20 characters")]
    public string Name { get; set; }
    [Required]
    [StringLength(20)]
    public string Breed { get; set; }
    [Required]
    [Range(0, 29, ErrorMessage = "Age must be between 0 and 29")]
    public int Age { get; set; }
    public string PicUrl { get; set; }
    [Required]
    public string Gender { get; set; }
  }
}