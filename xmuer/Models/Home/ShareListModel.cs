using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xmuer.Entities.Home;

namespace xmuer.Models.Home
{
	public class ShareListModel : PageModel
	{

		public List<Share> shares { get; set; }

		public ShareListModel()
		{
			shares = new List<Share>();
		}
	}
}
