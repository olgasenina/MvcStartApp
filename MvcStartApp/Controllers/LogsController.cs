using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Controllers
{
    public class LogsController : Controller
    {
        private readonly IRequestRepository _repo;

        public LogsController(IRequestRepository repo)
        {
            _repo = repo;
        }
        public async Task<IActionResult> Index()
        {
            var logs = await _repo.GetRequests();
            return View(logs);
        }
    }
}