using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarFleet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarFleet.Controllers
{
	public class AuctionController : Controller
	{
		private readonly ApplicationDbContext _db;
		public AuctionController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			return View();
		}
		public async Task<IActionResult> AllAuctions()
		{
			var offers = await _db.Offers.Include(c => c.Car).ToListAsync();
			return View(offers);


		}
	}
}
