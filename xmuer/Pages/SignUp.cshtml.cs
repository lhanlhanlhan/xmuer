using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
using xmuer.Entities.Home;
using xmuer.Mapper.Base;

namespace xmuer.Pages.Homepage
{
    public class SignUpModel : PageModel
    {
        private readonly MyContext _db;
        private Entities.Home.User user;

        public string userName { get; set; }
        public string userPass { get; set; }
        public string userPassAgain { get; set; }

        public SignUpModel(MyContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Entities.Home.User newUser = new Entities.Home.User();
            IEnumerator<KeyValuePair<string, StringValues>> enumerator = Request.Form.GetEnumerator();
            while (enumerator.MoveNext())
            {
                KeyValuePair<string, StringValues> single = enumerator.Current;
                if (single.Key == "userName") userName = single.Value.ToString();
                if (single.Key == "userPass") userPass = single.Value.ToString();
                if (single.Key == "userPassAgain") userPassAgain = single.Value.ToString();
            }
            if (userPass != userPassAgain) return Content("两次密码不一致");
            newUser.userName = userName;
            newUser.password = userPass;
            newUser.type = 1;
            newUser.state = 0;
            try
            {
                _db.Users.Add(newUser);
                _db.SaveChanges();
                _db.Entry(newUser);
                return Redirect("/SignIn");
            }
            catch
            {
                return Redirect("/SignUp");
            }
        }
    }
}
