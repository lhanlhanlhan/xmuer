using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using xmuer.Mapper.Base;

namespace xmuer.Pages.Album
{
    public class AlbumContentModel : PageModel
    {
        private readonly MyContext _db;
        private Entities.Home.Album albumInfo;

        public List<Entities.Home.Photo> Photos { get; set; }
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }

        public AlbumContentModel(MyContext db)
        {
            _db = db;
        }

        public IActionResult OnGet([FromQuery] string albumId)
        {
            try
            {
                AlbumId = int.Parse(albumId);
            }
            catch (Exception)
            {
                return Redirect("/Home/Album");
            }
            if (AlbumId <= 0)
            {
                return Redirect("/Home/Album");
            }
            // 获得 Album 的姓名
            albumInfo = _db.Albums.Find(AlbumId);
            if (albumInfo == null)
            {
                return Redirect("/Home/Album");
            }
            AlbumName = albumInfo.Name;
            GetAlbumContent();

            return Page();
        }

        // 获取相册内的相片
        private void GetAlbumContent()
        {
            var photoList = from ph in _db.Photos
                            where ph.AlbumID == AlbumId
                            select ph;
            Photos = photoList.ToList();
        }
    }
}
