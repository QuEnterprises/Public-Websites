using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HudAsp.Models;

namespace HudAsp.Controllers;

public class TablesController : Controller
{
		public IActionResult TableElements()
		{
				return View();
		}

		public IActionResult TablePlugins()
		{
				return View();
		}
}