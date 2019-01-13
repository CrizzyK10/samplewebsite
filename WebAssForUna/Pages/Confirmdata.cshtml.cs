using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using WebAssForUna.Model;

namespace WebAssForUna.Pages
{
	public class ConfirmdataModel : PageModel
	{

		[BindProperty]
		public Person Person { get; set; }

		public IActionResult OnGet()
		{
			var value = HttpContext.Session.GetString("person");

			if (value != null)
			{
				Person = JsonConvert.DeserializeObject<Person>(value);
				return Page();
			}
			else
			{
				return RedirectToPage("Error");
			}
		}

		public void OnPost()
		{

		}

	}
}