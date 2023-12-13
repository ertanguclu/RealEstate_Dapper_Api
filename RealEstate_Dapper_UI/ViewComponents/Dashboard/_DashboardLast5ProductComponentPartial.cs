using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.ViewComponents.Dashboard
{
    public class _DashboardLast5ProductComponentPartial:ViewComponent
    {
        public async  Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
