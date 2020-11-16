using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Blazor_Demo.Shared.Entities
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(10, ErrorMessage ="User name is too long. Only allow 10 characters.")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="The password is required.")]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        public ObservableCollection<BaseItem> UserItems { get; set;  }
    }
}
