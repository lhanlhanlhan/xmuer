using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xmuer.Entities.Home;

namespace xmuer.Mapper.Interface
{
	public interface IUserRepository
	{
		//取用户
		IEnumerable<User> GetUserByName(string name);
		//取用户
		IEnumerable<User> GetUserByStudentNo(string studentNo);
		//取用户
		IEnumerable<User> GetUserByColledge(string colledge);
		//取用户
		IEnumerable<User> GetUserByDepartment(string department);
		//取用户
		IEnumerable<User> GetUserByMajor(string major);
		//取全部用户
		IEnumerable<User> GetUsers();
	}
}
