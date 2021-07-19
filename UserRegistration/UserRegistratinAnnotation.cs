using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UserRegistration
{

    public class UserRegistrationAnnotation
    {
        //required condition is the field should not be null
        [Required(ErrorMessage = "{0} is required")]
        //length should be minimum of 3 and maximum of 50
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name should be min of 3")]
        //name should contain only character
        [DataType(DataType.Text)]
        public string firstName { get; set; }

        //required condition is the field should not be null
        [Required(ErrorMessage = "{0} is required")]
        //length should be minimum of 3 and maximum of 50
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name should be min of 3")]
        //name should contain only character
        [DataType(DataType.Text)]
        public string lastName { get; set; }

        //required condition is the field should not be null
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        //length should be minimum of 3 and maximum of 50
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone number should exactly 10")]
        public string phoneNumber { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }


        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
