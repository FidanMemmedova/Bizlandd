using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Fullname { get; set; }
        public string Position { get; set; }
        [NotMapped, Required]
        public IFormFile Photo { get; set; }
    }
}
