using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrganizationApp.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public long Tin { get; set; }

        public ICollection<Founder> Founders { get; set; }

        public Organization()
        {
            Founders = new List<Founder>();
        }
    }
}