using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SFFG.BAL.Models
{
    public class LessonDTO
    {
    
        public int Id { get; set; }
        public string LessonName { get; set; } = String.Empty!;
        public string? LessonPath { get; set; } = String.Empty!;
        public IFormFile? File { get; set; } = default!;
        public int? SectionId { get; set; }

    }
}
