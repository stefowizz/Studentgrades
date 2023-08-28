using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace roundthecode.pdf.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage ="This field is required")]
        [MaxLength(100, ErrorMessage ="Maximum 100 characters only!!!")]
        [DisplayName("First Name")]
        [Column(TypeName ="nvarchar(100)")] 
        public string? FirstName { get; set; }


        [Required(ErrorMessage = "Ths field is required")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters only!!!")]
        [DisplayName("Last Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string? LastName { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [MaxLength(7, ErrorMessage = "Maximum 7 characters only!!!")]
        [DisplayName("Grade Level")]
        [Column(TypeName = "nvarchar(7)")]
        public string? GrdaeLvl { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [MaxLength(30, ErrorMessage = "Maximum 30 characters only!!!")]
        [DisplayName("Teacher")]
        [Column(TypeName = "nvarchar(30)")]
        public string? Teacher { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [MaxLength(30, ErrorMessage = "Maximum 30 characters only!!!")]
        [DisplayName("Subject")]
        [Column(TypeName = "nvarchar(30)")]
        public string? Subject { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [MaxLength(20, ErrorMessage = "Maximum 20 characters only!!!")]
        [DisplayName("Gender")]
        [Column(TypeName = "nvarchar(20)")]
        public string? Sex { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [MaxLength(3, ErrorMessage = "Maximum 3 characters only!!!")]
        [DisplayName("First Score")]
        [Column(TypeName = "nvarchar(3)")]
        public string? Firstgrade { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [MaxLength(3, ErrorMessage = "Maximum 3 characters only!!!")]
        [DisplayName("Second Score")]
        [Column(TypeName = "nvarchar(3)")]
        public string? Secondgrade { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [MaxLength(3, ErrorMessage = "Maximum 3 characters only!!!")]
        [DisplayName("Third Score")]
        [Column(TypeName = "nvarchar(3)")]
        public string? Thirdgrade { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(3, ErrorMessage = "Maximum 3 characters only!!!")]
        [DisplayName("Average Score")]
        [Column(TypeName = "nvarchar(3)")]
        public string? Average { get; set; }

    }
}
