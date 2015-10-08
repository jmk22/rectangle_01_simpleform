using Nancy;
using System;
using System.Collections.Generic;

namespace RectangleChecker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["rectangle_form.cshtml"];
      };
      Get["/rectangle_result"] = _ => {
        Rectangle myRectangle = new Rectangle(Request.Query["side-length"], Request.Query["side-width"]);
        return View["rectangle_result.cshtml", myRectangle];
      };
    }
  }
}
