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
		[Required]
		[Display(Name ="Nazwa samochodu")]
		public string  CarName { get; set; }
		[Display(Name = "Kolor")]
		public string Color { get; set; }
		public enum EBody
		{
			Hatchback = 1, Kombi = 2, Sedan=3, SUV=4, Dostawcze=5

		}
		[Display(Name = "Rodzaj nadwozia")]
		public int Body { get; set; }
		[Display(Name = "Skrzynia")]
		public string Transmission { get; set; }
		public enum ETransmission
		{
			Manualna=1,Automatyczna=2

		}
		[Display(Name = "Nr rejestracyjny")]
		public string RegistarionNumber { get; set; }
		[Display(Name = "Liczba miejsc")]
		public int CountPlaces { get; set; }
		[Display(Name = "Rok produkcji")]
		public int ProductionYear { get; set; }
		[Display(Name = "Przebieg")]
		public long Mileage { get; set; }
		[Display(Name = "Pojemność")]
		public string Capacity { get; set; }
		[Display(Name = "Moc silnika")]
		public int EnginePower { get; set; }
		[Display(Name = "Rodzaj paliwa")]
		public string FuelType { get; set; }
		public enum EFuelType
		{
			Benzyna=1,Diesel=2,Gaz=3
				
		}
		[Display(Name ="Pierwsza rejestracja")]
		public DateTime FirstRegistarion { get; set; }
		[Display(Name = "Opis szczegółowy")]
		public string Description { get; set; }


	}
}
