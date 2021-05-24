using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCDemoApp.Models
{
    public class Attendee
    {
        [Required(ErrorMessage = "Name is compulsory field")]
        [StringLength(10, ErrorMessage = "Maximum Name length is 10 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is compulsory field")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is compulsory field")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")]
        public int? Phone { get; set; }

        [Required(ErrorMessage = "Select any one option")]
        public string WillAttend { get; set; }
    }
}
