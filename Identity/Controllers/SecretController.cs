using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Identity.Controllers
{
    [Authorize] //makes sure that identity of user is known to display content
    public class SecretController : Controller
    {
        
        public ContentResult Secret()
        {
            return Content("This is a secret...");
        }

        [AllowAnonymous] //overrides the above authorize
        public ContentResult Overt()
        {
            return Content("This is not a secret...");
        }
    }
}