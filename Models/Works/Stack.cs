using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamilyWebSite.Models
{
    public class Stack
    {
        public int Id { get; set; }

        public int PositionId { get; set; }

        public string Languages { get; set; }

        public string Frameworks { get; set; }

        public string Other { get; set; }
    }
}