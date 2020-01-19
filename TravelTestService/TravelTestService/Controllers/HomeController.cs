using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TravelTestService.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace TravelTestService.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.nights = 1;
           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string nights,string dest)
        {
            List<HotelListModel> list = null;

            string url = string.Format("{0}://{1}", HttpContext.Request.Scheme, HttpContext.Request.Host);
            url = url + "/api/API/findBargain/?destid=" + Convert.ToInt32(dest) + "&nights=" + Convert.ToInt32(nights);

            ResponseHandler resp;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    resp = JsonConvert.DeserializeObject<ResponseHandler>(apiResponse);
                }
            }

            JObject data = JObject.Parse(resp.response);

            if(data["hotels"] != null)
            {
                list = JsonConvert.DeserializeObject<List<HotelListModel>>(data["hotels"].ToString());
            }

            ViewBag.nights = nights;

            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
