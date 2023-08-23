using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CvProject.Models
{
    public partial class Education
    {
        public int Id { get; set; }
      
        public string? Title { get; set; }
        public string? Subtitle1 { get; set; }
        public string? Subtitle2 { get; set; }
        public string? AverageNote { get; set; }
        public string? Date { get; set; }
    }
}
