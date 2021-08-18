using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [Table("WorkInquiry")]
    public class WorkInquiry
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkInquiryId { get; set; }
        //[MaxLength(1000)]
        //[Required(ErrorMessage = "Description of work to be completed is required")]
        [Column(TypeName = "varchar(1000)")]
        public string Description { get; set; }
        //[MaxLength(50)]
        //[Required(ErrorMessage = "First name is required")]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        //[MaxLength(50)]
        //[Required(ErrorMessage = "Last name is required")]
        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }
        //[MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Phone number is required")]
        //[RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone number")]
        [Column(TypeName = "varchar(20)")]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "DateTime")]
        //[DataType(DataType.DateTime)]
        public DateTime? CreatedDate { get; set; }
    }
}
