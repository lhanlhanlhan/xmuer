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
    public class StatusListModel : PageModel
    {
        private readonly MyContext _db;
        private User user;
        public List<xmuer.Entities.Home.Status> statuses { get; set; }
        private int userId;

        public StatusListModel(MyContext db)
        {
            _db = db;
        }

        public IActionResult OnGet()
        {
            string tmp = HttpContext.Session.GetString("userId");
            if (tmp == "" || tmp == null)
            {
                return Redirect("/Homepage/SignIn");
            }
            userId = Convert.ToInt32(tmp);
            statuses = _db.Statuses.Where(s => s.UserID == userId)
                .ToList<Entities.Home.Status>();
            
            return Page();
        }
    }
}
