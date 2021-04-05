using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BowlingLeague.Models;
using Microsoft.EntityFrameworkCore;
using BowlingLeague.Models.ViewModels;

namespace BowlingLeague.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //This context is set below in the context = ctx and is used to pass into the view. 
        private BowlingLeagueContext _context { get; set; }

        //Bringing in the instance of the database here in the home controller
        public HomeController(ILogger<HomeController> logger, BowlingLeagueContext context)
        {
            _logger = logger;
            _context = context;
        }

        //The data type is long as seen on the default page when hovering over. The question mark after long makes it so that it can be a nullable value.
        public IActionResult Index(long? teamId, string teamName, int pageNum)
        {
            //Sets the page size to 5 (this controls how many results are shown on the page to 5)
            int pageSize = 5;

            //Uses the IndexViewModel to output the bowlers, page numbering, and team name info
            return View(new IndexViewModel
            {
                Bowlers = (_context.Bowlers
                    .Where(x => x.TeamId == teamId || teamId == null)
                    .OrderBy(x => x.BowlerFirstName)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize)
                    .ToList()),
                PageNumbering = new PageNumbering
                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pageNum,
                    //If no meal has been selected, then get full count. Otherwise, only count the number
                    //from the meal that has been selected.
                    TotalItems = (teamId == null ? _context.Bowlers.Count() :
                        _context.Bowlers.Where(x => x.TeamId == teamId).Count())
                },

                TeamName = teamName
            });
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
