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
		public double PriceFirst { get; set; }
		public double PriceActual { get; set; }
		public DateTime DateStart { get; set; }
		public DateTime DateEnd { get; set; }
		public string Location { get; set; }

	}
}
