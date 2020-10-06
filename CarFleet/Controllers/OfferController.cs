using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarFleet.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarFleet.Controllers
{
	public class OfferController : Controller
	{
		private readonly ApplicationDbContext _db;
		public OfferController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult CreateOffer()
		{
			Offers offerModel = new Offers();
			return View(offerModel);
		}
		

	}
}
