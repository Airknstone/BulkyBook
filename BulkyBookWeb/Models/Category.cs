using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key] //attribute that tells c# this is a primary key, type [key] and ctrl + . on key to open options and select using System 
        public int Id { get; set; }
        [Required] // sets Name as required
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
