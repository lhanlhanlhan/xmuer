using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using xmuer.Mapper.Base;

namespace xmuer.Pages.Examine
{
    public class ExamineModel : PageModel
    {
        private readonly MyContext _db;
        public List<xmuer.Entities.Home.User> users { get; set; }

        public ExamineModel(MyContext db)
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

            users = _db.Users.Where(s => s.state == 0).ToList();

            if (HttpContext.Request.Query.ContainsKey("id"))
            {
                if (HttpContext.Request.Query.ContainsKey("accept"))
                {
                    if (HttpContext.Request.Query["accept"] == "0")
                    {
                        ban(int.Parse(HttpContext.Request.Query["id"].ToString()));
                    }
                    else if (HttpContext.Request.Query["accept"] == "1")
                    {
                        pass(int.Parse(HttpContext.Request.Query["id"].ToString()));
                    }
                }

            }

            users = _db.Users.Where(s => s.state == 0).ToList();

            return Page();
        }

        public void pass(int index)
        {
            xmuer.Entities.Home.User user = users[index];
            user.state = 1;

            try
            {
                _db.Users.Update(user);
                _db.SaveChanges();
            }
            catch
            {
            }
        }

        public void ban(int index)
        {
            xmuer.Entities.Home.User user = users[index];
            user.state = -1;

            try
            {
                _db.Users.Update(user);
                _db.SaveChanges();
            }
            catch
            {
            }
        }

        public String passwordGrade(String password)
        {
            bool num = false;
            bool lowchar = false;
            bool highchar = false;
            bool other = false;
            foreach (char c in password)
            {
                if ('0' <= c && c <= '9')
                {
                    num = true;
                }
                else if ('a' <= c && c <= 'z')
                {
                    lowchar = true;
                }
                else if ('A' <= c && c <= 'Z')
                {
                    highchar = true;
                }
                else
                {
                    other = true;
                }
            }

            int grade = 0;
            if (num) grade++;
            if (lowchar) grade++;
            if (highchar) grade++;
            if (other) grade++;

            if (grade == 1) return "过于简单";
            if (grade == 2) return "简单";
            if (grade == 3) return "复杂";
            if (grade == 4) return "安全";

            return "密码不正确";
        }
    }
}
