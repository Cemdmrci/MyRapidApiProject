using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace MyRapidApiProject.Controllers
{
	public class ExchangeController : Controller
	{
		public async Task< IActionResult> Index()
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=EUR&amount=750"),
				Headers =
	{
		{ "x-rapidapi-key", "68eb318446mshffd79b1cafbc963p11cf5djsncafe11ee2e5d" },
		{ "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
			    var json=JObject.Parse(body);
				ViewBag.v = json["result"];
			}
			return View();
		}
	}
}
