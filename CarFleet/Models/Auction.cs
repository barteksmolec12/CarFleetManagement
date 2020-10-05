using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarFleet.Models
{
	public class Auction
	{
		[Key]
		public int Id { get; set; }
		public string Nick { get; set; }
		public int OfferId { get; set; }
		[ForeignKey("OfferId")]
		public Offers Offer { get; set; }
		public DateTime DateAuction { get; set; }
		public double Price { get; set; }
	}
}
