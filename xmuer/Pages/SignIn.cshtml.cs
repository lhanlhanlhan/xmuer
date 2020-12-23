using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
using xmuer.Entities.Home;
using xmuer.Mapper.Base;

namespace xmuer.Pages.Homepage
{
    public class SignInModel : PageModel
    {
        private readonly MyContext _db;
        private Entities.Home.User user;

        public string userName { get; set; }
        public string userPass { get; set; }

        public SignInModel(MyContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            IEnumerator<KeyValuePair<string, StringValues>> enumerator = Request.Form.GetEnumerator();
            while (enumerator.MoveNext())
            {
                KeyValuePair<string, StringValues> single = enumerator.Current;
                if (single.Key == "userName") userName = single.Value.ToString();
                if (single.Key == "userPass") userPass = single.Value.ToString();
            }
            try
            {
                var userList = from u in _db.Users
                                   where u.userName == userName
                                   select u;
                Entities.Home.User user = userList.First();
                if(user != null && user.password == userPass)
                {
                    HttpContext.Session.Clear();
                    HttpContext.Session.Set("userId", System.Text.Encoding.Default.GetBytes(user.ID.ToString()));
                    HttpContext.Session.Set("userName", System.Text.Encoding.Default.GetBytes(user.userName));
                }

                if (user.type == 100) {
                    return Redirect("/Examine/Examine");
                }

                return Redirect("/Homepage/UserHome");
            }
            catch
            {
                return Redirect("/SignIn");
            }

        }
    }
}
