using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P138Allup.Models
{
    public class Product : BaseEntity
    {
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [Column(TypeName ="money")]
        public double ExTax { get; set; }
        [Column(TypeName ="money")]
        public double Price { get; set; }
        [Column(TypeName ="money")]
        public double DiscountedPrice { get; set; }
        [Range(0,int.MaxValue)]
        public int Count { get; set; }
        public bool IsNewArrival { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsFeatured { get; set; }
        [StringLength(4)]
        public string Seria { get; set; }
        public int Code { get; set; }
        [StringLength(255)]
        public string? HoverImage { get; set; }
        [StringLength(255)]
        public string? MainImage { get; set; }
        public int? BrandId { get; set; }   
        public Brand? Brand { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
