using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RfidbasedAirportSecurity.Models
{
    public class Luggage
    {
        // Luggage_RFID_Id	Passenger_ID	Flight_Id	Luggage_Stage	Luggage_Location	Time

        [Key]
        public string Luggage_RFID_Id { get; set; } // Primary Key

        //[ForeignKey("PassengerDetails")]
        public string Passenger_ID { get; set; }
        public PassengerDetails PassengerDetails { get; set; }

        [ForeignKey("FlightDetails")]
        public string Flight_Id { get; set; }
        public FlightDetails FlightDetails { get; set; }

        public string Luggage_Stage { get; set; }
        public string Luggage_Location { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}