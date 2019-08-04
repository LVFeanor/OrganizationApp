using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrganizationApp.Models
{
    public class Founder
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }

        public int? OrganizationId { get; set; }
        public Organization Organizations { get; set; }
    }
}