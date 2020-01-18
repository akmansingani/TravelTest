using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTestService.Models
{
    public class HotelListModel
    {
        public HotelsModel hotel { get; set; }

        public List<RatesModel> rates { get; set; }

    }
}
