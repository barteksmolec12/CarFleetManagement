using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarFleet.Models
{
	public class Car
	{
		[Key]
		public int Id { get; set; }
		public string  CarName { get; set; }

		public string Color { get; set; }
		public int Body { get; set; }
		public Enum Transmisison  { get; set; }
		public string RegistarionNumber { get; set; }
		public int CountPlaces { get; set; }
		public int ProductionYear { get; set; }
		public int Mileage { get; set; }
		public double Capacity { get; set; }
		public int EnginePower { get; set; }
		public Enum FuelType { get; set; }
		public string Description { get; set; }


	}
}
