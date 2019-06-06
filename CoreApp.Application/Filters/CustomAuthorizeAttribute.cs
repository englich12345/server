using CoreApp.Application.Filters.Models;
using CoreApp.Application.Helpers;
using CoreApp.Application.Service;
using CoreApp.Application.ViewModels.System;
using CoreApp.Data.Entities;
using CoreApp.Persistence.Constants;
using CoreApp.Persistence.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace CoreApp.Application.Filters
{
    public class CustomAuthorizeAttribute : ActionFilterAttribute
    {
        private readonly IRoleService _roleService;

        public CustomAuthorizeAttribute(IRoleService roleService)
        {
            _roleService = roleService;
        }
        //public string Roles { get; set; }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var jwtHelper = (IJwtHelper)context.HttpContext.RequestServices.GetService(typeof(IJwtHelper));
            var accessToken = context.HttpContext.Request.Headers["x-access-token"].ToString();
            //Get controller
            var controller = context.RouteData.Values["Controller"].ToString();
            //Get Action
            var action = context.RouteData.Values["Action"].ToString();
            var jwtPayload = jwtHelper.ValidateToken(accessToken);

            if (jwtPayload == null)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                context.Result = new JsonResult(MessageConstants.INVALID_ACCESS_TOKEN);
            }
            else
            {
                foreach(var roleId in jwtPayload.RoleIds)
                {
                    var arrController = _roleService.GetController(roleId);
                    var arrAction = _roleService.GetAction(roleId);
                    bool isController = IsController(arrController.controller, controller);
                    bool isAction = IsAction(arrAction.action, action);
                    if (isAction && isController)
                        break;
                }

            }
            base.OnActionExecuting(context);
        }

        private bool IsController(string[] arrController, string controller )
        {
            int pos = Array.IndexOf(arrController, controller);
            if (pos > -1)
                return true;
            else
                return false;
        }

        private bool IsAction(string[] arrAction, string action)
        {
            int pos = Array.IndexOf(arrAction, action);
            if (pos > -1)
                return true;
            else
                return false;
        }
    }
}
