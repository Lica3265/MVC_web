using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mymagicwilltearyouapart.Models
{
 
      public class AuthorizePlusAttribute : AuthorizeAttribute        
        {
            public override void OnAuthorization(AuthorizationContext filterContext)
            {
                if (Convert.ToBoolean(filterContext.HttpContext.Session["auth"]))
                {
                    //驗證成功
                }
                else
                {
                    //驗證失敗直接丟回 401
                    base.HandleUnauthorizedRequest(filterContext);
                }
            }
        }
    
}