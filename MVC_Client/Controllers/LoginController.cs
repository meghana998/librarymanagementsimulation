using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc_Client.Models;

namespace Mvc_Client.Controllers
{
    public class LoginController : Controller
    {
        [Route("Login/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginWin(LoginViewModel user)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44396/");

                //HTTP POST
                var postTask = await client.PostAsJsonAsync<LoginViewModel>("api/Token", user);
                if (postTask.IsSuccessStatusCode)
                {
                    var token = await postTask.Content.ReadAsStringAsync();
                    TempData["token"] = token;
                    return RedirectToAction("Index","Catalog");
                }
            }

            return RedirectToAction("Login","Login");
        }
    }
}
