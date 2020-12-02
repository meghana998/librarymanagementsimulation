using AddNewBook_API.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
//using lib_manag_sys.Repository;
using System.IO;
using log4net;
using log4net.Config;


[assembly: log4net.Config.XmlConfigurator(ConfigFile = "Log4net.config", Watch = true)]
namespace AddNewBook_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class AddNewBookDetailsController : Controller
    {
        private readonly IAddNewBook ibook;
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AddNewBookDetailsController(IAddNewBook ibook)
        {
            this.ibook = ibook;
        }

        [HttpGet]
        [Route("GetAllBooks")]
        public IActionResult GetAllBooks()
        {
            BasicConfigurator.Configure();
            log.Info("entering into get all books");
            return Ok(ibook.DisplayAllBooks());
        }

        // POST api/<ValuesController>
        [HttpPost]
        [Route("AddNewBook")]
        
        public IActionResult AddNewBook([FromBody] Book value)
        {
            BasicConfigurator.Configure();
            log.Info("Adding a newbook" + value);
            bool result = ibook.AddNewBook(value);
            
            if (result == false)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }

      
        
        

       

        
    }
}
