using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostJLProyect.Controllers
{
    public class EsSeguraAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            IDictionary<string, object> actionParameters = filterContext.ActionParameters;

            String pw = actionParameters["pw"].ToString();

            if (pw.Length < 6)
            {
                filterContext.Result = new EmptyResult();
            }
            else
            {
                base.OnActionExecuting(filterContext);

            }
        }
    }
}