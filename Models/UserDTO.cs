using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFFG.BAL.Models
{
    public class UserDTO
    {
        public string UserId { get; set; } = String.Empty!;
        public string FirstName { get; set; } = String.Empty!;
        public string LastName { get; set; } = String.Empty!;
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string Role { get; set; } = String.Empty!;
        public int? SectionId { get; set; }
        public string? Password { get; set; }
    }
}
