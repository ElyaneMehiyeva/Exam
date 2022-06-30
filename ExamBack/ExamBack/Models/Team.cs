using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamBack.Models
{
    public class Team
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string Image { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string Description { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
    }
}
