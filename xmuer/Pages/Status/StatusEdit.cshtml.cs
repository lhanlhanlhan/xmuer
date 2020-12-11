using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using xmuer.Mapper.Base;

namespace xmuer.Pages.Status
{
    public class StatusEditModel : PageModel
    {
        private readonly MyContext _db;
        private int userId;

        public StatusEditModel(MyContext db)
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

            if (HttpContext.Request.Query.ContainsKey("new"))
            {

            }
            else
            {

            }
            return Page();
        }

        
        public IActionResult OnPost()
        {
            string tmp = HttpContext.Session.GetString("userId");
            if (tmp == "" || tmp == null)
            {
                return Redirect("/SignIn");
            }
            userId = Convert.ToInt32(tmp);

            if (HttpContext.Request.Query.ContainsKey("new")) //新建状态
            {
                if(HttpContext.Request.Query.ContainsKey("submit")) //发布
                {
                    Entities.Home.Status status = new Entities.Home.Status();
                    status.UserID = int.Parse(HttpContext.Session.GetString("userId"));
                    status.Content = HttpContext.Request.Form["content"];
                    status.Like = 0;
                    status.State = 2;
                    _db.Statuses.Add(status);
                    _db.SaveChanges();
                    _db.Entry(status);
                }
                if (HttpContext.Request.Query.ContainsKey("save")) //暂存
                {
                    Entities.Home.Status status = new Entities.Home.Status();
                    status.UserID = int.Parse(HttpContext.Session.GetString("userId"));
                    status.Content = HttpContext.Request.Form["content"];
                    status.Like = 0;
                    status.State = 1;
                    _db.Statuses.Add(status);
                    _db.SaveChanges();
                    _db.Entry(status);
                }

            }

            return Page();
        }

    }
}
