using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using TravelTestService.Models;

namespace TravelTestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private IConfiguration _config;

        public APIController(IConfiguration config)
        {
            _config = config;
        }

        // GET: api/API
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("findBargain")]
        public async Task<ActionResult> findBargain(int destId, int nights)
        {
            ResponseHandler resp;

            try
            {
                string url = _config["apiUrl"] + "?destid=" + destId +"&nights=" + nights + "&code=" + _config["SecretKey"];

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(url))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        resp = JsonConvert.DeserializeObject<ResponseHandler>(apiResponse);
                    }
                }

                if (resp.status == "error")
                {
                    return BadRequest(resp);
                }

                return Ok(resp);
            }
            catch(Exception)
            {
                return BadRequest("error occured");
            }
            
        }

    }
}
