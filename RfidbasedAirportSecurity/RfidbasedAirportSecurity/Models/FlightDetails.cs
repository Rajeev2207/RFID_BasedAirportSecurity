using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RfidbasedAirportSecurity.Models
{
    public class FlightDetails
    {
        // Flight_Id	Source	Destination	Boarding Gate	Boarding_Time
        // Departure_Time	Arrival_Time	Status	Belt_Id

        [Key]
        public string Flight_Id { get; set; } // Primary Key

        [Required]
        public string Source { get; set; } // Not Null
        [Required]
        public string Destination { get; set; } // Not Null

        public string Boarding_Gate { get; set; }
        public DateTime Boarding_Time { get; set; }
        public DateTime Arrival_Time { get; set; }
        public DateTime Departure_Time { get; set; }
        public string Status { get; set; }
        public string Belt_Id { get; set; }

    }
}