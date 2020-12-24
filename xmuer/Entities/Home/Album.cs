using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace xmuer.Entities.Home
{
	[Table("album")]
	public class Album
	{
		[Key]
		[Column("id")]
		public int ID { get; set; }

		[Column("user_id")]
		public int UserID { get; set; }

		[Column("picture")]
		public string Picture { get; set; }

		[Column("name")]
		public string Name { get; set; }
	}
}
