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
		[ValidateAntiForgeryToken]
		[HttpPost]
		public async Task <IActionResult> CreateOffer(Offers offerModel)
		{
			if(ModelState.IsValid)
			{
				offerModel.PriceActual = offerModel.PriceFirst;
				offerModel.DateStart = DateTime.Now;
				_db.Offers.Add(offerModel);
				await _db.SaveChangesAsync();
				return RedirectToAction(nameof(CreateOffer));
			}
			return View(offerModel);

		}


	}
}
