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

        public void OnGet()
        {
            // 获取当前登录的用户
            //userId = Convert.ToInt32(HttpContext.Session.GetString("userId"));
            user = _db.Users.Find(Convert.ToInt32("1"));
            userInfo = _db.UserInfos.Find(Convert.ToInt32("1"));
            WelcomeMessage = user.userName;
            StudySchool = userInfo.university != null ? userInfo.university : "...";
        }

    }
}
