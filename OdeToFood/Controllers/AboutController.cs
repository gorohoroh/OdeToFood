using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{

    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "1+555+555+5555";
        }
        
        public string Address()
        {
            return "USA";
        }
    }
}