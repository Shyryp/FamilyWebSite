using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamilyWebSite.Models.Job
{
    public class Job
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int PositionId { get; set; } 
    }
}