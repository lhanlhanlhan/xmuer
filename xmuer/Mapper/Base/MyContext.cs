using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xmuer.Entities.Home;

namespace xmuer.Mapper.Base
{
	public class MyContext : DbContext
	{
		public MyContext(DbContextOptions<MyContext> options)
			: base(options)
		{ }

		public DbSet<Album> Albums { get; set; }

		public DbSet<User> Users { get; set; }

		public DbSet<UserInfo> UserInfos { get; set; }

		public DbSet<Photo> Photos { get; set; }

		public DbSet<Status> Statuses { get; set; }

	}
}
