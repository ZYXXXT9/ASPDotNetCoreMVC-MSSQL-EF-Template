using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASPDotNetCoreMVC_MSSQL_EF_Template.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is Required.")]
        public string? FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is Required.")]
        public string? LastName { get; set; }
        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "Date of Birth is Required.")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
    }
}
