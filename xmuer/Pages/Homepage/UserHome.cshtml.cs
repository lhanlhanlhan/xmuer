using System;
using System.Collections.Generic;
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
    public class UserHomeModel : PageModel
    {
        private readonly MyContext _db;
        private Entities.Home.User user;
        private int userId;

        public UserHomeModel(MyContext db)
        {
            _db = db;
        }

        public string WelcomeMessage { get; set; }
        public string StudySchool { get; set; }

        public IActionResult OnGet()
        {
            // �ж��Ƿ��������˷���
            int id = -1;
            IEnumerator<KeyValuePair<string, StringValues>> enumerator = HttpContext.Request.Query.GetEnumerator();
            while (enumerator.MoveNext())
            {
                KeyValuePair<string, StringValues> single = enumerator.Current;
                if (single.Key == "id") id = single.Value.ToString() != null ? Convert.ToInt32(single.Value.ToString()) : 0;
            }
            if (id > 0)
            {
                // ��ȡ��ǰ��¼���û�
                user = _db.Users.Find(id);
                if (user != null)
                {
                    WelcomeMessage = user.userName;
                    StudySchool = user.university != null ? user.university : "...";
                    return Page();
                }
            }
            // ��ȡ��ǰ��¼���û�
            string tmp = HttpContext.Session.GetString("userId");
            if(tmp == "" || tmp == null)
            {
                return Redirect("/SignIn");
            }
            userId = Convert.ToInt32(tmp);
            user = _db.Users.Find(userId);
            WelcomeMessage = user.userName;
            StudySchool = user.university != null ? user.university : "...";
            return Page();
        }
    }
}
