using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFFG.BAL.Models
{
    public class TokenDTO
    {
        public string Access_Token { get; set; } = String.Empty;
        public string? Refresh_Token { get; set; }
    }
}
