using System.ComponentModel.DataAnnotations;

namespace BasicAuthentication.Models
{
    public class User : BaseModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
