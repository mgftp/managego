﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using PropertyChanged;

namespace ManageGo
{
    [AddINotifyPropertyChangedInterface]
    public class Building
    {
        public int BuildingId { get; set; }
        public int PropertyId { get; set; }

        public string BuildingName { get; set; }
        public string BuildingShortAddress { get; set; }

        [JsonProperty(PropertyName = "MaintenanceEnabled")]
        public bool IsMaintenanceEnabled { get; set; }

        public List<Unit> Units { get; set; }

        // TODO: Find a better way to split this up
        [JsonProperty(PropertyName = "NumberOfUnits")]
        public int UnitCount { get; set; }

        [JsonProperty(PropertyName = "NumberOfTenant")]
        public int TenantCount { get; set; }

        [JsonProperty(PropertyName = "NumberOfOpenTickets")]
        public int OpenTicketCount { get; set; }

        [JsonIgnore, AlsoNotifyFor("CheckBoxImage")]
        public bool IsSelected { get; set; }

        [JsonIgnore]
        public string CheckBoxImage
        {
            get
            {
                return IsSelected ? "checked.png" : "unchecked.png";
            }
        }
    }
}
