﻿using System;
using Newtonsoft.Json;

namespace MGDataAccessLibrary.Models.Amenities.Responses
{
    public class Building
    {
        public int BuildingId { get; set; }
        public string BuildingDescription { get; set; }
        [JsonIgnore]
        public bool IsSelected { get; set; }
    }
}