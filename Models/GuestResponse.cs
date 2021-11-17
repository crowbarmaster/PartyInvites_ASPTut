using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "You must include your name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must inclue a properly formmated email address!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please include a phone number:")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify if you will intend!")]
        public bool? WillAttend { get; set; }
    }
}
