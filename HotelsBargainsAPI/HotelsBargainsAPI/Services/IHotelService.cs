using HotelsBargainsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsBargainsAPI.Services
{
    public interface IHotelService
    {
        Task<ResponseHandler> findBargain(int destinationId,int nights);
    }
}
