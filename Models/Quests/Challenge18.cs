//Challenge 18 (Add Validation Rules to Quest)

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ForgingAhead.Models
{
  public class Quest
  {
    [Key]
    [Required]
    [MinLength(3)]
    public string Name { get; set; }
    [Required]
    [Display(Name = "Is Active")]
    public bool IsActive { get; set; }

    public List<Character> Characters { get; set; }
  }
}
