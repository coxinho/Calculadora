using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Calculadora2020.Models;


namespace Calculadora2020.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;


		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}






		/// <summary>
		/// apresenta a View com a calculadora, no primeiro pedido - HTTP GET
		/// </summary>
		/// <returns></returns>
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(string a)
		{
			return View();
		}














		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}


