using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace WebBatDongSan.App_Code
{
	public class SubcribeController : SurfaceController
	{
		public ActionResult DoSubcribe()
		{
			string email = Request["email"];
			var rootNode = Umbraco.TypedContentAtRoot().First();
			var subcribe = rootNode.DescendantsOrSelf("subcribe").First();
			var service = Services.ContentService;
			var person = service.CreateContent(email, subcribe.Id, "subcriber");
			service.SaveAndPublishWithStatus(person);
			return RedirectToUmbracoPage(rootNode.Id);
		}
	}
}