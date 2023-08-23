using System;
using System.Collections.Generic;

namespace CvProject.Models
{
    public partial class About
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Adress { get; set; }
        public string? Phone { get; set; }
        public string? Mail { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}
