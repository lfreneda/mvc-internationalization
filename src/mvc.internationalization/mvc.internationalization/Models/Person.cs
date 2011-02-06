using System.ComponentModel.DataAnnotations;

namespace mvc.internationalization.Models
{
    public class Person
    {
        [Required(ErrorMessageResourceType = typeof(mvc.internationalization.resources.Resources),
        ErrorMessageResourceName = "FirstNameRequired")]
        [StringLength(50, ErrorMessageResourceType = typeof(mvc.internationalization.resources.Resources),
        ErrorMessageResourceName = "FirstNameInvalid")]
        public string FirstName { get; set; }

        [Required(ErrorMessageResourceType = typeof(mvc.internationalization.resources.Resources),
        ErrorMessageResourceName = "LastNameRequired")]
        [StringLength(50, ErrorMessageResourceType = typeof(mvc.internationalization.resources.Resources),
        ErrorMessageResourceName = "LastNameInvalid")]
        public string LastName { get; set; }

        [Required(ErrorMessageResourceType = typeof(mvc.internationalization.resources.Resources),
        ErrorMessageResourceName = "EmailRequired")]
        [RegularExpression(".+@.+\\..+", ErrorMessageResourceType = typeof(mvc.internationalization.resources.Resources),
        ErrorMessageResourceName = "EmailInvalid")]     
        public string Email { get; set; }

        [Range(0, 100, ErrorMessageResourceType = typeof(mvc.internationalization.resources.Resources),
        ErrorMessageResourceName = "FavoriteNumberInvalid")]
        public int FavoriteNumber { get; set; }
    }
}