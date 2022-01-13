using Abc.Facade.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.People {
    public sealed class PersonView : UniqueEntityView {
        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z '-]*$",
            ErrorMessage = "Invalid last name")]
        [DisplayName("Last Name")] public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z '-]*$",
        ErrorMessage = "Invalid first middle name")]
        [DisplayName("First Middle Name")] public string FirstMidName { get; set; }

        [Required]
        [StringLength(12)]
        [RegularExpression(@"^(\+[0-9]{3}(?!(0))[0-9]{8})$",
            ErrorMessage = "Not a valid phone number. Number should not start with 0 and must contain country code and only digits")]
        [DisplayName("Phone Number")] public string PhoneNumber { get; set; }

        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Invalid email")]
        [DisplayName("Email")] public string Email { get; set; }
        [DisplayName("Gender")] public string Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")] public DateTime? DateOfBirth { get; set; }

    }
}
