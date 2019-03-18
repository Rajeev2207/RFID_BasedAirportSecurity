using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RfidbasedAirportSecurity.Models
{
    public class ZoneAccessMetaData
    {
        // Role	Type/Class	Zone1	Zone2	Zone3
        [Key]
        public string Role { get; set; }

        public string ClassType { get; set; }

        public bool B1 { get; set; }
        public bool C1 { get; set; }
        public bool D3 { get; set; }
        public bool E1 { get; set; }
        public bool F1 { get; set; }
        public bool G1 { get; set; }


    }
}