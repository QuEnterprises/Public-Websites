using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HudAsp.Models;

namespace HudAsp.Controllers;

public class UiKitsController : Controller {
	public IActionResult Bootstrap()
	{
			return View();
	}

	public IActionResult Buttons()
	{
			return View();
	}

	public IActionResult Card()
	{
			return View();
	}

	public IActionResult Icons()
	{
			return View();
	}

	public IActionResult ModalNotifications()
	{
			return View();
	}

	public IActionResult Typography()
	{
			return View();
	}

	public IActionResult TabsAccordions()
	{
			return View();
	}
}