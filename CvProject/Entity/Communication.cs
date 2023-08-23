using System;
using System.Collections.Generic;

namespace CvProject.Models
{
    public partial class Communication
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Mail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime Date { get; set; }
    }
}
