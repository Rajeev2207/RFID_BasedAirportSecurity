using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RfidbasedAirportSecurity.Models
{
    public class PassengerAreaAccess
    {
        // Zone_id	RFID_Id	AccessTime	Role

        [Key]
        public string ZoneId { get; set; }  // Primary Key

        [ForeignKey("RfidInventory")]
        public string RFID_ID { get; set; }
        public RfidInventory RfidInventory { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]  // similar to SYSDATE
        public DateTime Access_Time { get; set; }

        [ForeignKey("ZoneAccessMetaData")]
        public string Role { get; set; }
        public ZoneAccessMetaData ZoneAccessMetaData { get; set; }
    }
}