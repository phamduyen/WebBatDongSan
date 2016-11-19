using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
namespace WebBatDongSan.Controllers
{
    public class lienHeController : RenderMvcController
    {
       //GET: lienHe
        public ActionResult LienHe(RenderModel model)
        {
            if(Request.HttpMethod == "GET")
            {
              var fullName = Request["fullname"];
              var phone = Request["phone"];
              var email = Request["email"];   
              var address = Request["address"];
              var message = Request["message"];
              var contentService = Services.ContentService;
              var person = contentService.CreateContent(fullName, model.Content.Id,"person");
              person.SetValue("phone",phone);
              person.SetValue("email",email);
              person.SetValue("address",address);
              person.SetValue("message",message);
              contentService.SaveAndPublishWithStatus(person);
            }
           return CurrentTemplate(model);
        }
    }
}