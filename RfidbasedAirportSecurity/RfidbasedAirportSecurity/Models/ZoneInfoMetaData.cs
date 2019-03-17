﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RfidbasedAirportSecurity.Models
{
    public class ZoneInfoMetaData
    {
        // Zone_Id	Rfid_Reader_Id	Lat/Long

        [Key]
        public string ZoneId { get; set; }

        [ForeignKey("RfidInventory")]
        public int RFID_ID { get; set; }
        public RfidInventory RfidInventory { get; set; }

        [Required]
        public string Lat_Long { get; set; }
    }
}