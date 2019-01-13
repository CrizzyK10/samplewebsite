using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebAssForUna.Model
{
	public class Person
	{
		[BindProperty]
		[Required]
		public string FName { get; set; }

		[BindProperty]
		[Required]
		public string SName { get; set; }

		[BindProperty]
		[Required]

		public string PPSN { get; set; }

		[BindProperty]
		[Required]
		[DataType(DataType.Date)]
		public string DOB { get; set; }

		[BindProperty]
		[Required]
		public string Gender { get; set; }

		[BindProperty]
		[Required]
		[Range(110, 200)]
		public string Height { get; set; }

		[BindProperty]
		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[BindProperty]
		[Required]
		[RegularExpression(@"08[3679]\d{7}", ErrorMessage = "Invalid Number. Please Try Again")]
		public string PNumber { get; set; }

		[BindProperty]
		[Required]
		public string RStatus { get; set; }

		[BindProperty]
		[Required]
		public bool[] Interests { get; set; } = { false, false, false, false, false, false, false, false, false, false };

		public string[] InterestsArray = { "Outdoor sports", "Food", "Pubs", "Cinema", "Theatre", "Music", "Reading", "Gaming", "Watching sport", "Board games" };
	}
}
