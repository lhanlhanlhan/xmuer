﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace xmuer.Entities.Home
{
	[Table("comment")]
	public class Comment
	{
		[Key]
		[Column("id")]
		public int ID { get; set; }

		[Column("status_id")]
		public int StatusID { get; set; }

		[Column("content")]
		public string Content { get; set; }
	}
}
