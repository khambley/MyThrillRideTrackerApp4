﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyThrillRideTrackerApp4.Models
{
	public class Ride : BaseModel
    {
        public int RideId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Height { get; set; }

        public int Length { get; set; }

        [Display(Name = "Top Speed")]
        public int TopSpeed { get; set; } //mph

        public int GForce { get; set; }

        public string RideType { get; set; }
        public string ThrillType { get; set; }
        public string MaterialType { get; set; }

        public string WebsiteLink { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [Display(Name = "Build Date")]
        public DateTime BuildDate { get; set; }

        public string Manufacturer { get; set; }

        public int ParkId { get; set; }
        public Park Park { get; set; }
    }
}
