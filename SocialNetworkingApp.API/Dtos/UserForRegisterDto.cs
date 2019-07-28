using System.ComponentModel.DataAnnotations;

namespace SocialNetworkingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify Password between 4 and 8 characters")]
        public string Password { get; set; }
    }
}