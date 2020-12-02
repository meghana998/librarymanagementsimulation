using Booksearch_API.Repository;
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
namespace Booksearch_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class DisplayDetailsController : Controller
    {
        private readonly IGetBookDetails ibook;
        public DisplayDetailsController(IGetBookDetails _ibook)
        {
            this.ibook = _ibook;
        }
        // GET: DisplayDetailsController
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        [HttpGet]
        [Route("GetAllBooks")]
        public IActionResult GetAllBooks()
        {
            BasicConfigurator.Configure();
            log.Info("entering into get all books");
            return Ok(ibook.DisplayAllBooks());
        }
        [HttpGet]
        [Route("DetailsById")]
        // GET: DisplayDetailsController/Details/5
        public IActionResult DetailsById(int id)
        {
            BasicConfigurator.Configure();
            log.Info("entering into get book by id"+id);
            Book received = ibook.GetBookInfo(id);
            if (received != null)
            {
                return Ok(received);
            }
            else
            {
                return BadRequest();
            }
            
        }

    }
}
