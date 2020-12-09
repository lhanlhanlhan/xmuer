using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using xmuer.Entities.Home;
using xmuer.Mapper.Base;

namespace xmuer.Pages.Homepage
{
    public class UserInfoModel : PageModel
    {
        private readonly MyContext _db;
        private Entities.Home.User user;
        public UserInfo userInfo;
        private int userId;
        [BindProperty]
        public UserInfo userInputInfo { get; set; }

        public UserInfoModel(MyContext db)
        {
            _db = db;
            user = _db.Users.Find(userId);
            userInfo = _db.UserInfos.Find(userId);
            userInputInfo = userInfo;
        }

        public IActionResult OnGet()
        {
            string tmp = HttpContext.Session.GetString("userId");
            if (tmp == "" || tmp == null)
            {
                return Redirect("/Homepage/SignIn");
            }
            userId = Convert.ToInt32(tmp);
            user = _db.Users.Find(userId);
            userInfo = _db.UserInfos.Find(userId);
            userInputInfo = userInfo;
            return Page();
        }

        public IActionResult OnPost()
        {
            userInfo = _db.UserInfos.Find(Convert.ToInt32(HttpContext.Session.GetString("userId")));
            userInfo.university = userInputInfo.university != null ? userInputInfo.university : userInfo.university;
            userInfo.highSchool = userInputInfo.highSchool != null ? userInputInfo.highSchool : userInfo.highSchool;
            userInfo.juniorHighSchool = userInputInfo.juniorHighSchool != null ? userInputInfo.juniorHighSchool : userInfo.juniorHighSchool;
            userInfo.primarySchool = userInputInfo.primarySchool != null ? userInputInfo.primarySchool : userInfo.primarySchool;
            
            userInfo.hobbyMusic = userInputInfo.hobbyMusic != null ? userInputInfo.hobbyMusic : userInfo.hobbyMusic;
            userInfo.hobbyBook = userInputInfo.hobbyBook != null ? userInputInfo.hobbyBook : userInfo.hobbyBook;
            userInfo.hobbyMovie = userInputInfo.hobbyMovie != null ? userInputInfo.hobbyMovie : userInfo.hobbyMovie;
            userInfo.hobbyGame = userInputInfo.hobbyGame != null ? userInputInfo.hobbyGame : userInfo.hobbyGame;
            userInfo.hobbyAnime = userInputInfo.hobbyAnime != null ? userInputInfo.hobbyAnime : userInfo.hobbyAnime;
            userInfo.hobbySport = userInputInfo.hobbySport != null ? userInputInfo.hobbySport : userInfo.hobbySport;
            userInfo.hobbyOther = userInputInfo.hobbyOther != null ? userInputInfo.hobbyOther : userInfo.hobbyOther;

            userInfo.realName = userInputInfo.realName != null ? userInputInfo.realName : userInfo.realName;
            userInfo.gender = userInputInfo.gender != 0 ? userInputInfo.gender : userInfo.gender;
            userInfo.birthday = userInputInfo.birthday.Ticks != 0 ? userInputInfo.birthday : userInfo.birthday;
            userInfo.hometown = userInputInfo.hometown != null ? userInputInfo.hometown : userInfo.hometown;
            userInfo.email = userInputInfo.email != null ? userInputInfo.email : userInfo.email;
            userInfo.mobile = userInputInfo.mobile != null ? userInputInfo.mobile : userInfo.mobile;
            try
            {
                _db.UserInfos.Update(userInfo);
                _db.SaveChanges();
                return Page();
            }
            catch
            {
                return Redirect("/Homepage/UserInfo");
            }
        }

    }
}
