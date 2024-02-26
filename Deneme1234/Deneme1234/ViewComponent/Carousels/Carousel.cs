using System;
using Deneme1234.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Deneme1234.ViewComponents.Carousel
{
	public class Carousel:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			Context c = new Context();

			var carousels = c.Carousels.ToList();

			return View(carousels);
		}


	}
}

