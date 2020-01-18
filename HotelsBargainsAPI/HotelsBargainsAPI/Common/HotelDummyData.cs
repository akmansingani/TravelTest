using HotelsBargainsAPI.Models;
using HotelsBargainsAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsBargainsAPI.Common
{
    public static class HotelDummyData
    {
        public static void fillHotelData()
        {
            HotelService._hotelData = new List<HotelListModel>()
            {
                new HotelListModel
                {
                    hotel = new HotelsModel {
                           name = "Property 1",
                           geoId = 1,
                           propertyID = 1,
                           rating = 3
                    },
                    rates = new List<RatesModel>()
                    {
                        new RatesModel
                        {
                            rateType = "PerNight",
                            boardType = "No Meals",
                            value = 100
                        },
                        new RatesModel
                        {
                            rateType = "PerNight",
                            boardType = "Half Board",
                            value = 150
                        },
                        new RatesModel
                        {
                            rateType = "PerNight",
                            boardType = "Full Board",
                            value = 200
                        }
                    }
                },
               new HotelListModel
                {
                    hotel = new HotelsModel {
                           name = "Property 2",
                           geoId = 2,
                           propertyID = 2,
                           rating = 5
                    },
                    rates = new List<RatesModel>()
                    {
                        new RatesModel
                        {
                            rateType = "Stay",
                            boardType = "No Meals",
                            value = 500
                        },
                        new RatesModel
                        {
                            rateType = "Stay",
                            boardType = "Half Board",
                            value = 1000
                        },
                        new RatesModel
                        {
                            rateType = "Stay",
                            boardType = "Full Board",
                            value = 1500
                        }
                    }
                },
               new HotelListModel
                {
                    hotel = new HotelsModel {
                           name = "Property 3",
                           geoId = 1,
                           propertyID = 3,
                           rating = 4
                    },
                    rates = new List<RatesModel>()
                    {
                        new RatesModel
                        {
                            rateType = "Stay",
                            boardType = "No Meals",
                            value = 400
                        },
                        new RatesModel
                        {
                            rateType = "Stay",
                            boardType = "Half Board",
                            value = 850
                        },
                        new RatesModel
                        {
                            rateType = "Stay",
                            boardType = "Full Board",
                            value = 1250
                        }
                    }
                },
               new HotelListModel
                {
                    hotel = new HotelsModel {
                           name = "Property 4",
                           geoId = 2,
                           propertyID = 4,
                           rating = 4
                    },
                    rates = new List<RatesModel>()
                    {
                        new RatesModel
                        {
                            rateType = "PerNight",
                            boardType = "No Meals",
                            value = 200
                        },
                        new RatesModel
                        {
                            rateType = "PerNight",
                            boardType = "Half Board",
                            value = 400
                        },
                        new RatesModel
                        {
                            rateType = "PerNight",
                            boardType = "Full Board",
                            value = 600
                        }
                    }
                }
            };

            HotelService._geoDestData = new List<GeoDestinationModel>()
           {
               new GeoDestinationModel
               {
                   DestID = 1,
                   GeoID = 1,
               },
               new GeoDestinationModel
               {
                   DestID = 2,
                   GeoID = 2,
               }
           };
        }
    }
}
