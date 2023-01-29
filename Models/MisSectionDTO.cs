using SFFG.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFFG.BAL.Models
{
    public class MisSectionDTO
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string SectionName { get; set; } = null!;
        public string Advisor { get; set; } = null!;
        public int NoOfStudents { get; set; }

    }
}
