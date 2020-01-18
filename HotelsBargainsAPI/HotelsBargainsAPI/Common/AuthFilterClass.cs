using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace HotelsBargainsAPI.Common
{
    public class AuthFilterClass : Attribute, IAuthorizationFilter
    {
        public static string code { get; set; }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            Boolean data = IsRequestAuthorized(context);
            if (!data)
            {
                context.Result = new UnauthorizedObjectResult("You do not have access to this API. Please use a valid key.");
                return;
            }
           
        }

        private Boolean IsRequestAuthorized(AuthorizationFilterContext filterContext)
        {
            try
            {
                var secret = filterContext.HttpContext.Request.Query.SingleOrDefault(x => x.Key == "code").Value;

                return secret.Count > 0 ? (secret == code ? true : false) : false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
