using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
using xmuer.Entities.Home;
using xmuer.Mapper.Base;

namespace xmuer.Pages.Homepage
{
    public class UserInfoModel : PageModel
    {
        private readonly MyContext _db;
        public Entities.Home.User user;
        private int userId;

        public string iuniversity { get; set; }
        public string ihighSchool { get; set; }
        public string ijuniorHighSchool { get; set; }
        public string iprimarySchool { get; set; }
        public string ihobbyMusic { get; set; }
        public string ihobbyBook { get; set; }
        public string ihobbyMovie { get; set; }
        public string ihobbyGame { get; set; }
        public string ihobbyAnime { get; set; }
        public string ihobbySport { get; set; }
        public string ihobbyOther { get; set; }
        public string irealName { get; set; }
        public int igender { get; set; }
        public DateTime ibirthday { get; set; }
        public string ihometown { get; set; }
        public string iemail { get; set; }
        public string imobile { get; set; }

        public UserInfoModel(MyContext db)
        {
            _db = db;
            user = _db.Users.Find(userId);
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
            iuniversity = user.university;
            ihighSchool = user.highSchool;
            ijuniorHighSchool = user.juniorHighSchool;
            iprimarySchool = user.primarySchool;
            ihobbyMusic = user.hobbyMusic;
            ihobbyBook = user.hobbyBook;
            ihobbyMovie = user.hobbyMovie;
            ihobbyGame = user.hobbyGame;
            ihobbyAnime = user.hobbyAnime;
            ihobbySport = user.hobbySport;
            ihobbyOther = user.hobbyOther;
            irealName = user.realName;
            igender = user.gender;
            ibirthday = user.birthday;
            ihometown = user.hometown;
            iemail = user.email;
            imobile = user.mobile;
            return Page();
        }

        public IActionResult OnPost()
        {
            user = _db.Users.Find(Convert.ToInt32(HttpContext.Session.GetString("userId")));
            IEnumerator<KeyValuePair<string, StringValues>> enumerator = Request.Form.GetEnumerator();
            while (enumerator.MoveNext())
            {
                KeyValuePair<string, StringValues> single = enumerator.Current;
                if (single.Key == "iuniversity") user.university = single.Value.ToString();
                if (single.Key == "ihighSchool") user.highSchool = single.Value.ToString();
                if (single.Key == "ijuniorHighSchool") user.juniorHighSchool = single.Value.ToString();
                if (single.Key == "iprimarySchool") user.primarySchool = single.Value.ToString();
                if (single.Key == "ihobbyMusic") user.hobbyMusic = single.Value.ToString();
                if (single.Key == "ihobbyBook") user.hobbyBook = single.Value.ToString();
                if (single.Key == "ihobbyMovie") user.hobbyMovie = single.Value.ToString();
                if (single.Key == "ihobbyGame") user.hobbyGame = single.Value.ToString();
                if (single.Key == "ihobbyAnime") user.hobbyAnime = single.Value.ToString();
                if (single.Key == "ihobbySport") user.hobbySport = single.Value.ToString();
                if (single.Key == "ihobbyOther") user.hobbyOther = single.Value.ToString();
                if (single.Key == "irealName") user.realName = single.Value.ToString();
                if (single.Key == "igender") user.gender = single.Value.ToString() != null ? Convert.ToInt32(single.Value.ToString()) : 0;
                if (single.Key == "ibirthday")
                {
                    DateTime dt;
                    DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                    dtFormat.ShortDatePattern = "yyyy-MM-dd";
                    dt = Convert.ToDateTime(single.Value.ToString(), dtFormat);
                    user.birthday = dt;
                }
                if (single.Key == "ihometown") user.hometown = single.Value.ToString();
                if (single.Key == "iemail") user.email = single.Value.ToString();
                if (single.Key == "imobile") user.mobile = single.Value.ToString();
            }
            try
            {
                _db.Users.Update(user);
                _db.SaveChanges();
                return Redirect("/Homepage/UserInfo");
            }
            catch
            {
                return Redirect("/Homepage/UserInfo");
            }
        }

    }
}
