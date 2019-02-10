using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Genre
    {
        public byte Id { get; set; }
        
        [StringLength(255)]
        public string Name { get; set; }
    }
}