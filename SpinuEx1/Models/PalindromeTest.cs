using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SpinuEx1.Models
{
    public class PalindromeTest
    {
        [DisplayName ("Numeric value")]
        [MaxLength (20)]
        public string InputNumeric { get; set; }
        [DisplayName ("Palindrome Test Result")]
        public string Result { get; set; }
        public string ErrorMessage { get; set; }

        public PalindromeTest() {
            InputNumeric = string.Empty;
            Result = string.Empty;
            ErrorMessage = string.Empty;
        }
    }
}
