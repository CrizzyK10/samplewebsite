using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using WebAssForUna.Model;

namespace WebAssForUna.Pages
{
	public class formModel : PageModel
    {
		//Getting and setting Variables//
		
		[BindProperty]
		public Person Person { get; set; } = new Person();

		public void OnGet()
		{
			var value = HttpContext.Session.GetString("person");
			if (value != null)
			{
				Person = JsonConvert.DeserializeObject<Person>(value);
			}
		}
		[HttpPost]
		public IActionResult OnPost()
		{
			if (ModelState.IsValid)
			{

				var serialisedData = JsonConvert.SerializeObject(Person);

				HttpContext.Session.SetString("person", serialisedData);

				return RedirectToPage("Confirmdata");

			}
			else
			{
				return Page();
			}
		}
	}
}