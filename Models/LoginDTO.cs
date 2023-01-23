using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFFG.BAL.Models
{
    public class LoginDTO
    {
        public string UserId { get; set; } = String.Empty!;
        public string Password { get; set; } = String.Empty!;
        public string? Email { get; set; }    
    }
}
