using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using msg_board.Models;
using msg_board.Data;

namespace msg_board.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DBContext _ctx;

        public HomeController(ILogger<HomeController> logger, DBContext ctx)
        {
            _logger = logger;
            _ctx = ctx;

        }

        public async Task<IActionResult> Index()
        {
            var posts = _ctx.Messages.Where(m => true).ToList();
            var data = new HomeMessageVM
            {
                PostMessage = new Message(),
                Messages = posts
            };

            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PostNewMessage(string msg){
            Message newPost = new Message {
                MessageText = msg
            };

            await _ctx.Messages.AddAsync(newPost);

            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
