﻿using System.ComponentModel.DataAnnotations;

namespace ShowroomManagmentAPI.DTOs
{
    public class VehicleDTO
    {
        public int VehicleId { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string Mileage { get; set; }
        [MaxLength(17)]
        public string VIN { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public IFormFile ProfileImagePath { get; set; }
    }
}
