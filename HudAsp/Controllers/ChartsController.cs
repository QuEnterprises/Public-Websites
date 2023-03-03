using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HudAsp.Models;

namespace HudAsp.Controllers;

public class ChartsController : Controller
{
		public IActionResult ChartJs()
		{
				return View();
		}

		public IActionResult ApexchartsJs()
		{
				return View();
		}
}
