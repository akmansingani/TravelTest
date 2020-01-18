using HotelsBargainsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsBargainsAPI.Services
{
    public class HotelService : IHotelService
    {
        private IHttpContextAccessor _context;

        public static List<HotelListModel> _hotelData;

        public static List<GeoDestinationModel> _geoDestData;

        public HotelService(IHttpContextAccessor context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<ResponseHandler> findBargain(int destinationId, int nights)
        {
            try
            {
               var hotels = await Task.Factory.StartNew(() => 
                {
                    var t = from query1 in _hotelData.AsQueryable()
                                 join query2 in _geoDestData.AsQueryable() on query1.hotel.geoId equals query2.GeoID
                                 where query2.DestID == destinationId
                                 select new
                                 {
                                     query1.hotel,
                                     rates = from query3 in query1.rates
                                            select new
                                            {
                                                query3.rateType,
                                                query3.boardType,
                                                value = (query3.rateType == "Stay" ? query3.value : query3.value * nights)
                                            }
                                 };

                    return t;
                });
               

                return new ResponseHandler
                {
                    status = "success",
                    response = JsonConvert.SerializeObject(new
                    {
                        hotels
                    })
                };

            }
            catch (Exception ex)
            {
                return new ResponseHandler
                {
                    status = "error",
                    response = "Please try later!"
                };
            }

            
        }
    }
}
