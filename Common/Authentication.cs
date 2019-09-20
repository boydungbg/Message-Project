using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Project_Email.Controllers;

namespace Project_Email.Common
{
    public class Authentication : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var userId = context.HttpContext.Session.GetInt32("userId");
            if (userId == null)
            {
                var controller = (Controller)context.Controller;
                context.Result = controller.Redirect("/User/Login");
            }
        }
    }
}