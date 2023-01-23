using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFFG.BAL.Models
{
    public class SectionDTO
    {
        public int Id { get; set; }
        public string SectionName { get; set; } = null!;
        public string Advisor { get; set; } = null!;
    }
}
