﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsBargainsAPI.Models
{
    public class HotelsModel
    {
        public int propertyID { get; set; }

        public string name { get; set; }

        public int geoId { get; set; }

        public int rating { get; set; }

    }
}
