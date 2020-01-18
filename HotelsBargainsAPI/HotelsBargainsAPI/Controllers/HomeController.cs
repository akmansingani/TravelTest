using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelsBargainsAPI.Common;
using HotelsBargainsAPI.Models;
using HotelsBargainsAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace HotelsBargainsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IHotelService _hotelService;

        public HomeController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        // GET: api/Home
        [HttpGet]
        public string Get()
        {
            return "its working";
        }
        

        [HttpGet("findBargain")]
        [TypeFilter(typeof(AuthFilterClass))]
        public async Task<ActionResult> findBargain(int destId, int nights)
        {

            ResponseHandler resp = await _hotelService.findBargain(destId, nights);

            if (resp.status == "error")
            {
                return BadRequest(resp);
            }

            return Ok(resp);
        }   

   
    }
}
