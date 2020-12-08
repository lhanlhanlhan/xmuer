using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DiscussClassSystem.Common.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xmuer.Common.Infrastructure;
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
		protected IPhotoService PhotoService;
		#endregion

		#region 构造函数

		public AlbumController(IAlbumService albumService, IPhotoService photoService)
		{
			AlbumService = albumService;
			PhotoService = photoService;
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

		[HttpPost("{id}")]
		public async Task<IActionResult> uploadPhoto(int id, IFormFile iFormFile)
		{
			Message message = new Message();
			if (iFormFile == null || iFormFile.Length == 0)
				return new JsonResult(new Message((int)MessageCode.UPLOAD_FILE_EMPTY,
					MessageCode.UPLOAD_FILE_EMPTY.GetDescription()));
			var filePath = "wwwroot/album/" + iFormFile.FileName;
			Console.WriteLine(filePath);
			Console.WriteLine(iFormFile.FileName);
			using (var stream = new FileStream(filePath,
			FileMode.Create))
			{
				await iFormFile.CopyToAsync(stream);
			}
			Photo photo = new Photo();
			photo.Picture = "~/album/" + iFormFile.FileName;
			photo.AlbumID = id;
			message = PhotoService.CreatePhoto(photo);
			return new JsonResult(message);
		}

		[HttpPost]
		public ActionResult<Message> createAlbum(Album album)
		{
			if (album.Picture == null)
				album.Picture = "~/album/timg.png";
			string tmp = HttpContext.Session.GetString("userId");
			int userId = Convert.ToInt32(tmp);
			album.UserID = userId;
			Message message = AlbumService.CreateAlbum(album);
			return new JsonResult(message);
		}

	}
}
