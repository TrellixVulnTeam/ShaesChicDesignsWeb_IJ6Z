using System;

namespace WebAPI.Models
{
    public class WorkInquiry
    {
        public int WorkInquiryId { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
