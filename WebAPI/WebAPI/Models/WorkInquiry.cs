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
        public string Description { get; set; }
        //[MaxLength(50)]
        //[Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        //[MaxLength(50)]
        //[Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        //[MaxLength(50)]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Phone number is required")]
        //[RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone number")]
        public string PhoneNumber { get; set; }
        //[Required]
        public DateTime? CreatedDate 
        {   
            get
            {
                return DateTime.Now;
            }
            
            set
            {
                CreatedDate = value;
            }
        }
    }
}
