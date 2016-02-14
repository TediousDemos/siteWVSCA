using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace siteWVSCA.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(70,ErrorMessage = null, MinimumLength = 1)]
        [Display(Name = "First name")]
        public string NameFirst { get; set; }

        [Required]
        [StringLength(70, ErrorMessage = "", MinimumLength = 1)]
        [Display(Name = "Last Name")]
        public string NameLast { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "", MinimumLength = 1)]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "", MinimumLength = 1)]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "", MinimumLength = 1)]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "", MinimumLength = 5)]
        [Display(Name = "ZIP code")]
        public string Zip { get; set; }

        [Phone]
        [Display(Name = "Telephone")]
        public string Telephone { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public System.DateTime BirthDate { get; set; }

        [StringLength(6)]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [StringLength(8,ErrorMessage ="USCF IDs are 8 numbers",MinimumLength = 8)]
        [Display(Name = "USCF ID")]
        public string USCFID { get; set; }

        [Required]
        [StringLength(4,ErrorMessage ="Give in format of MMYY",MinimumLength = 4)]
        [Display(Name = "USCF Expiration Date")]
        public string USCFExpire { get; set; }

        [StringLength(4, MinimumLength = 3)]
        [Display(Name = "USCF Rating")]
        public string USCFRating { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Section")]
        public string Section { get; set; }

        [Required]
        [StringLength(100,MinimumLength =1)]
        [Display(Name = "School Name")]
        public string SchoolName { get; set; }

        [StringLength(100)]
        [Display(Name = "School City")]
        public string SchoolCity { get; set; }

        [Required]
        [StringLength(2)]
        [Display(Name = "Grade")]
        public string Grade { get; set; }

        [StringLength(100)]
        [Display(Name = "Contact Firstname")]
        public string ContactFirstname { get; set; }

        [StringLength(100)]
        [Display(Name = "Contact Lastname")]
        public string ContactLastname { get; set; }

        [EmailAddress]
        [Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }

        [StringLength(100, ErrorMessage = "", MinimumLength = 1)]
        [Display(Name = "Contact Street Address")]
        public string ContactStreetAddress { get; set; }

        [StringLength(100, ErrorMessage = "", MinimumLength = 1)]
        [Display(Name = "Contact City")]
        public string ContactCity { get; set; }

        [StringLength(100, ErrorMessage = "", MinimumLength = 1)]
        [Display(Name = "Contact State")]
        public string ContactState { get; set; }

        [Phone]
        [Display(Name = "Contact Phone number")]
        public string ContactPhone { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
