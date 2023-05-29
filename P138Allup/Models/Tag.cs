using System.ComponentModel.DataAnnotations;

namespace P138Allup.Models
{
    public class Tag : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
    }
}
