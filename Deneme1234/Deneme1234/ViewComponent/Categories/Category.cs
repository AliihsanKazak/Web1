using System;
using Deneme1234.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Deneme1234.ViewComponents.Category
{
	public class Category:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			Context c = new Context();

			

			return View();
		}



	}
}

