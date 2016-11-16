using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EKSponsor.Models;

namespace EKSponsor.Controllers
{
    public class SponsorController : ApiController
    {
        Sponsor[] Sponsor = new Sponsor[]
        {
            new Sponsor { MemberID=1, MemberName="Clement", MemberType ="M" },
            new Sponsor { MemberID=2, MemberName="Bryan", MemberType ="M" },
            new Sponsor { MemberID=3, MemberName="Han Kheng", MemberType ="F" }
        };

        public IEnumerable<Sponsor> GetAllSponsors()
        {
            return Sponsor;
        }

        public IHttpActionResult GetSponsor(int id)
        {
            var sponsor = Sponsor.FirstOrDefault((p) => p.MemberID == id);
            if (sponsor == null)
            {
                return NotFound();
            }
            return Ok(sponsor);
        }

    }

   
}
