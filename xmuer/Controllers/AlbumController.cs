using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscussClassSystem.Common.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xmuer.Entities.Home;
using xmuer.Models.Home;
using xmuer.Service.Interface;

namespace xmuer.Controllers.Home
{
	[Route("home/[controller]")]
	[ApiController]
	public class AlbumController : Controller
	{
		#region 属性声明

		protected IAlbumService AlbumService;
		#endregion

		#region 构造函数

		public AlbumController(IAlbumService albumService)
		{
			AlbumService = albumService;
		}

		#endregion

		[HttpGet]

		public IActionResult GetAlbumList()
		{

			AlbumListModel albumListModel = new AlbumListModel();

			IEnumerable<Album> albumIE = AlbumService.GetAlbumsByUserID(1);
			if (albumIE != null)
			{
				albumListModel.albums.AddRange(albumIE);
			}

			return View("Pages/Album/AlbumList.cshtml",albumListModel);
		}

		[HttpPost("id")]
		public IActionResult uploadPhoto()
		{
			return View();
		}
	}
}
