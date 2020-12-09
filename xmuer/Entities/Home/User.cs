using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace xmuer.Entities.Home
{
	[Table("user")]
	public class User
	{
		[Key]
		[Column("id")]
		public int ID { get; set; }

		[Column("user_name")]
		public String userName { get; set; }

		[Column("password")]
		public String password { get; set; }

		[Column("state")]
		public int state { get; set; }

		[Column("type")]
		public int type { get; set; }


        #region 新鲜事页面所需字段
        [Column("real_name")]
		public String realName { get; set; }

		[Column("student_no")]
		public string StudentNo { get; set; }

		[Column("college")]
		public string College { get; set; }

		[Column("department")]
		public string Department { get; set; }

		[Column("major")]
		public string Major { get; set; }

		[Column("avatar")]
		public string Avatar { get; set; }

		#endregion
	}
}
