using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_With_EFCore.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required (ErrorMessage ="Book Title Must be provided")]
        [StringLength(50, MinimumLength = 2)]
        public string BookTitle { get; set; }
        [Required(ErrorMessage = "Please provide Author Name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage ="Length must be within 2 to 100 characters")]
        public string AuthorName { get; set; }
        [Required(ErrorMessage = "Publisher Name is must")]
        [StringLength(100, MinimumLength = 2,ErrorMessage ="Must be with 2 to 100 characters")]
        public string Publisher { get; set; }
        public string Genre { get; set; }
        [Required(ErrorMessage = "Book Price is must")]
        [DataType(DataType.Currency)]
        [Range(1, 999,ErrorMessage ="Must be with range from 1 to 999")]
        public int Price { get; set; }
    }
}
