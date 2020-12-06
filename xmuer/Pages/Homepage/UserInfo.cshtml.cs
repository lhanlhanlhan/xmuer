using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace xmuer.Pages.Homepage
{
    public class UserInfoModel : PageModel
    {

        private String userName;
        private String userId;

        public void OnGet()
        {
            userName = HttpContext.Session.GetString("userName");
            userId = HttpContext.Session.GetString("userId");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            return Page();
        }
    }
}
