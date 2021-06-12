using System.Web.Mvc;

namespace ZFine.Web.Areas.GuiZheManage
{
    public class GuiZheManageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "GuiZheManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "GuiZheManage_default",
                "GuiZheManage/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
