//Challenge 1 (Add Quests to DbContext)
using System.ComponentModel.DataAnnotations;

namespace ForgingAhead.Models
{
  public class Quest
  {
        [Key]
        public string Name { get; set; }
        public bool IsActive { get; set; }
  }
}
