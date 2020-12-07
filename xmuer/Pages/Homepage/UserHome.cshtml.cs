using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using xmuer.Entities.Home;
using xmuer.Mapper.Base;

namespace xmuer.Pages.Homepage
{
    public class UserHomeModel : PageModel
    {
        private readonly MyContext _db;
        private User user;
        private UserInfo userInfo;
        private int userId;

        public UserHomeModel(MyContext db)
        {
            _db = db;
        }

        public string WelcomeMessage { get; set; }
        public string StudySchool { get; set; }

        public IActionResult OnGet()
        {
            // 获取当前登录的用户
            string tmp = HttpContext.Session.GetString("userId");
            if(tmp == "" || tmp == null)
            {
                return Redirect("/Homepage/SignIn");
            }
            userId = Convert.ToInt32(tmp);
            user = _db.Users.Find(userId);
            userInfo = _db.UserInfos.Find(userId);
            WelcomeMessage = user.userName;
            StudySchool = userInfo.university != null ? userInfo.university : "...";
            return Page();
        }
    }
}
