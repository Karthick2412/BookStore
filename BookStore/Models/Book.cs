using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Book Name")]
        public string BookName { get; set; }
        [DisplayName("Author Name")]
        public string AuthorName { get; set; }
    }
}
