using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xmuer.Entities.Home;
using xmuer.Mapper.Base;
using xmuer.Mapper.Interface;

namespace xmuer.Mapper.Implement
{
	public class AlbumRepository : IAlbumRepository
	{
		#region 属性声明

		public MyContext Context;

		#endregion

		#region 构造函数

		public AlbumRepository(MyContext context)
		{
			Context = context;
		}

		#endregion

		#region 相册操作

		//创建相册
		public bool CreateAlbum(Album album)
		{
			Context.Albums.Add(album);
			return Context.SaveChanges() > 0;
		}

		//取全部相册
		public IEnumerable<Album> GetAlubums()
		{
			return Context.Albums;
		}

		//修改相册封面
		public bool ModefiyAlbumPictureByID(int id, string picture)
		{
			var upState = false;


			var album = Context.Albums.SingleOrDefault(s => s.ID == id);
			album.Picture = picture;
			upState = Context.SaveChanges() > 0;
			return upState;
		}
		//通过ID取相册
		public Album GetAlbumByID(int id)
		{
			return Context.Albums.SingleOrDefault(s => s.ID == id);
		}

		//通过用户ID取相册
		public IEnumerable<Album> GetAlbumsByUserID(int userID)
		{
			return Context.Albums.Where(s => s.UserID == userID);
		}

		//删除相册
		public bool DeleteAlbumByID(int id)
		{
			var album = Context.Albums.SingleOrDefault(s => s.ID == id);
			Context.Albums.Remove(album);
			return Context.SaveChanges() > 0;
		}

		#endregion

	}
}
