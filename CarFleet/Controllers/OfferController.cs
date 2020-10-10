using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarFleet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
		public async Task<IActionResult> OffersManagment()
		{
			var offers = await _db.Offers.Include(c => c.Car).ToListAsync();
			return View(offers);


		}

		[HttpPost]
		public async Task<IActionResult> Delete(int id)
		{
			
				var offerFromDb = await _db.Offers.FindAsync(id);
				_db.Offers.Remove(offerFromDb);
				await _db.SaveChangesAsync();
				return RedirectToAction(nameof(OffersManagment));
			
		}
		public async Task <IActionResult> Edit(int? id)
		{
			if(id ==null)
			{
				return NotFound();
			}

			var offerFromDb = await _db.Offers.Include(m=>m.Car).FirstOrDefaultAsync(m => m.Id == id);
			
			return View(offerFromDb);
		}
		[ValidateAntiForgeryToken]
		[HttpPost]
		public async Task<IActionResult> Edit(Offers offerModel)
		{
			if (ModelState.IsValid)
			{

				//var offerFromDb = await _db.Offers.Include(s => s.Car).Where(s => s.CarId == offerModel.CarId).FirstOrDefaultAsync();
				_db.Offers.Update(offerModel);	
				await _db.SaveChangesAsync();
				return RedirectToAction(nameof(OffersManagment));
			}
			return View(offerModel);

		}


	}
}
