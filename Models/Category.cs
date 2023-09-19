using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    [Table("TblCategory")]
    public class Category
    {
        [Key]
        public int CatID { get; set; }
        public string CTitle { get; set; } = "Soaps";
        public string? Photo { get; set; }

    }


    [Table("TblProduct")]
    public class Product
    {
        [Key]
        public int PID { get; set; }
        [Required(ErrorMessage ="Enter Product Name")]
        [Display(Name ="Product Name")]
        public string PName { get; set; } = "Soaps";

        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Product Date")]
        public DateTime? PDate { get; set; }

        public string? Photo { get; set; }

        public Category? Pcategory { get; set; }


    }
}
