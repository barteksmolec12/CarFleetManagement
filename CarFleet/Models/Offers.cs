using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarFleet.Models
{
	public class Offers
	{
		[Key]
		public int Id { get; set; }
		public int CarId { get; set; }
		[ForeignKey("CarId")]
		public Car Car { get; set; }
		[Display(Name="Cena wywoławcza")]
		public double PriceFirst { get; set; }
		[Display(Name = "Cena aktualna")]
		public double PriceActual { get; set; }
		
		public DateTime DateStart { get; set; }
		[Display(Name = "Data zakończenia")]
		public DateTime DateEnd { get; set; }
		[Display(Name = "Lokalizacja")]
		public string Location { get; set; }

	}
}
