using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using xmuer.Entities.Home;
using xmuer.Mapper.Base;

namespace xmuer.Pages.Status
{
    public class StatusDraftListModel : PageModel
    {
        private readonly MyContext _db;
        public List<xmuer.Entities.Home.Status> statuses { get; set; }
        private int userId;

        public StatusDraftListModel(MyContext db)
        {
            _db = db;
        }

        public IActionResult OnGet()
        {
            string tmp = HttpContext.Session.GetString("userId");
            if (tmp == "" || tmp == null)
            {
                return Redirect("/SignIn");
            }
            userId = Convert.ToInt32(tmp);
            statuses = _db.Statuses.Where(s => s.UserID == userId).Where(s => s.State == 1)
                .ToList<Entities.Home.Status>();

            return Page();
        }
    }
}
