using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFFG.BAL.Models
{
    public class RefreshTokenDTO
    {
        public string UserId { get; set; } = String.Empty!;
        public string? RefToken { get; set; }
        public int IsActive { get; set; }
    }
}
