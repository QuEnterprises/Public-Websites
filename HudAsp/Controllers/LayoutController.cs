using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HudAsp.Models;

namespace HudAsp.Controllers;

public class LayoutController : Controller
{
		public IActionResult StarterPage()
		{
				return View();
		}

		public IActionResult FixedFooter()
		{
				return View();
		}

		public IActionResult FullHeight()
		{
				return View();
		}

		public IActionResult FullWidth()
		{
				return View();
		}

		public IActionResult BoxedLayout()
		{
				return View();
		}

		public IActionResult CollapsedSidebar()
		{
				return View();
		}
}