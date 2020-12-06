using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace xmuer.Entities.BackManage
{
	[Table("admin")]
	public class Admin
	{
		[Key]
		[Column("id")]
		public int ID { get; set; }
	}
}
