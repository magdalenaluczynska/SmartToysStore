using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SmartToysStore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        public string Description { get; set; }
        [Required]
        public string ModelCode { get; set; }
        [Required]
        [Display(Name = "Price 1-50")]
        public double Price { get; set; }
        [Required]
        [Display(Name = "Price 50+")]
        public double Price50 { get; set; }
        [Required]
        [Display(Name = "Price 100+")]
        public double Price100 { get; set; }
        public string Color { get; set; }
        [ValidateNever]
        public string Link { get; set; }
        [ValidateNever]
        public string Image { get; set; }

    }
};