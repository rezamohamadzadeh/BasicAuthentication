using System.ComponentModel.DataAnnotations;

namespace BasicAuthentication.Models
{
    public class Customer : BaseModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
