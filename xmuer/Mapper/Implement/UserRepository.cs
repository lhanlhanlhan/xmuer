using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xmuer.Entities.Home;
using xmuer.Mapper.Base;
using xmuer.Mapper.Interface;

namespace xmuer.Mapper.Implement
{
	public class UserRepository : IUserRepository
	{
		#region 属性声明

		public MyContext Context;

		#endregion

		#region 构造函数

		public UserRepository(MyContext context)
		{
			Context = context;
		}

		#endregion

		#region 用户信息操作

		//取用户
		public IEnumerable<User> GetUserByName(string name)
		{
			return Context.Users.Where(s => s.realName == name);
		}
		//取用户
		public IEnumerable<User> GetUserByStudentNo(string studentNo)
		{
			return Context.Users.Where(s => s.StudentNo == studentNo);
		}
		//取用户
		public IEnumerable<User> GetUserByColledge(string colledge)
		{
			return Context.Users.Where(s => s.College == colledge);
		}
		//取用户
		public IEnumerable<User> GetUserByDepartment(string department)
		{
			return Context.Users.Where(s => s.Department == department);
		}
		//取用户
		public IEnumerable<User> GetUserByMajor(string major)
		{
			return Context.Users.Where(s => s.Major == major);
		}

		//取全部用户
		public IEnumerable<User> GetUsers()
		{
			return Context.Users;
		}

		#endregion
	}
}
