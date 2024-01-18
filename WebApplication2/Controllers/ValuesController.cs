using Microsoft.AspNetCore.Mvc;
using WebApplication2.Model;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public ActionResult Customervalidation(string Emailid)
        {
            SqlExecution sqe = new SqlExecution();
        string validation=    sqe.customervalidtion(Emailid);
            return Ok(validation);
        }
     
    }
}
