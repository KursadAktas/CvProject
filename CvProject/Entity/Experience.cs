using System;
using System.Collections.Generic;

namespace CvProject.Models
{
    public partial class Experience
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public string? Description { get; set; }
        public string? Date { get; set; }
    }
}
