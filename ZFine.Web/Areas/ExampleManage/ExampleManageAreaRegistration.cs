﻿using System.Web.Mvc;

namespace ZFine.Web.Areas.ExampleManage
{
    public class ExampleManageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ExampleManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                this.AreaName + "_Default",
                this.AreaName + "/{controller}/{action}/{id}",
                new { area = this.AreaName, controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "ZFine.Web.Areas." + this.AreaName + ".Controllers" }
            );
        }
    }
}
