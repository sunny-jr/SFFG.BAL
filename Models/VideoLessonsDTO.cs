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
    public class VideoLessonsDTO
    {
        public int Id { get; set; }
        public string VideoName { get; set; } = String.Empty!;
        public string VideoPath { get; set; } = String.Empty!;
        public IFormFile VideoFile { get; set; } = default!;
        public int? SectionId { get; set; }
    }
}
