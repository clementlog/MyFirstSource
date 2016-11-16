using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EKSponsor.Models
{
    public class Sponsor
    {
        public int MemberID{ get; set; }
        public string MemberName { get; set; }
        public string MemberType { get; set; }
    }
}