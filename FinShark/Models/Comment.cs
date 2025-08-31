using System.ComponentModel.DataAnnotations.Schema;

namespace FinShark.Models
{
    [Table("Comments")]
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? StockId { get; set; } // Foreign key linking the comment to a specific stock
        public Stock? Stock { get; set; } // Navigation property for accessing the related Stock entity i.e. different parts of stock
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
