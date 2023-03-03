using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HudAsp.Models;

namespace HudAsp.Controllers;

public class PagesController : Controller
{
		public IActionResult ScrumBoard()
		{
				return View();
		}
		
		public IActionResult Products()
		{
				return View();
		}
		
		public IActionResult ProductDetails()
		{
				return View();
		}
		
		public IActionResult Orders()
		{
				return View();
		}
		
		public IActionResult OrderDetails()
		{
				return View();
		}
		
		public IActionResult Gallery()
		{
				return View();
		}

		public IActionResult SearchResults()
		{
				return View();
		}

		public IActionResult ComingSoonPage()
		{
				return View();
		}

		public IActionResult ErrorPage()
		{
				return View();
		}

		public IActionResult Login()
		{
				return View();
		}

		public IActionResult Register()
		{
				return View();
		}

		public IActionResult Messenger()
		{
				return View();
		}

		public IActionResult DataManagement()
		{
				return View();
		}
}
