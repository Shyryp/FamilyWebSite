using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamilyWebSite.Models
{
    public class SocialLink
    {
        public int Id { get; set; }
        
        public string URL { get; set; }

        public int SocialNetworkId { get; set; }
    }
}