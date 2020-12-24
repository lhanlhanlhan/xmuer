using DiscussClassSystem.Common.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xmuer.Entities.Home;

namespace xmuer.Service.Interface
{
	public interface IAlbumService
	{
		#region 相册操作

		//创建相册
		Message CreateAlbum(Album album);

		//取全部相册
		IEnumerable<Album> GetAlubums();

		//通过ID取相册
		Album GetAlbumByID(int id);

		//通过用户ID取相册
		IEnumerable<Album> GetAlbumsByUserID(int userID);

		//通过用户ID分页取相册
		IEnumerable<Album> GetAlbumsByUserID(int userID, int pageLimit, int pageIndex);

		//修改相册封面
		Message ModefiyAlbumPictureByID(int id, string picture);
		
		//删除相册
		Message DeleteAlbumByID(int id);

		#endregion
	}
}
