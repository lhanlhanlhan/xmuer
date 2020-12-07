using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xmuer.Entities.Home;

namespace xmuer.Models.Home
{
	public class AlbumListModel : PageModel
	{
		public  List<Album> albums { get; set; }

		public AlbumListModel()
		{
			albums = new List<Album>();
		}
	}
}
