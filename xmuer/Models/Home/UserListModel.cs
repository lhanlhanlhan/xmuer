using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xmuer.Entities.Home;

namespace xmuer.Models.Home
{
	public class UserListModel : PageModel
	{
		public List<User> users { get; set; }

		public UserListModel()
		{
			users = new List<User>();
		}
	}
}
