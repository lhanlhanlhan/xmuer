using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace xmuer.Pages.Homepage
{
    public class UserHomeModel : PageModel
    {
        private String userName;
        private String userId;

        public string WelcomeMessage { get; set; }

        public void OnGet()
        {
            // 获取当前登录的用户
            userName = HttpContext.Session.GetString("userName");
            userId = HttpContext.Session.GetString("userId");
            if (userName != null)
            {
                WelcomeMessage = userName;
            }
            //else
            //{
            //    RedirectToPage("");
            //}
        }

        public async Task<IActionResult> OnPostAsync()
        {
            WelcomeMessage = "lalala";

            return Page();
        }
    }
}
