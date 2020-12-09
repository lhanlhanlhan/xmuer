using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xmuer.Entities.Home;
using xmuer.Mapper.Interface;
using xmuer.Service.Interface;

namespace xmuer.Service.Implement
{
	public class UserService : IUserService
	{
		#region 属性声明

		IUserRepository UserRepository;

		#endregion

		#region	构造函数
		public UserService(IUserRepository userRepository)
		{
			UserRepository = userRepository;
		}
		#endregion

		//取用户
		public IEnumerable<User> GetUserByName(string name)
		{
			return UserRepository.GetUserByName(name);
		}
		//取用户
		public IEnumerable<User> GetUserByStudentNo(string studentNo)
		{
			return UserRepository.GetUserByStudentNo(studentNo);
		}
		//取用户
		public IEnumerable<User> GetUserByColledge(string colledge)
		{
			return UserRepository.GetUserByColledge(colledge);
		}
		//取用户
		public IEnumerable<User> GetUserByDepartment(string department)
		{
			return UserRepository.GetUserByDepartment(department);
		}
		//取用户
		public IEnumerable<User> GetUserByMajor(string major)
		{
			return UserRepository.GetUserByMajor(major);
		}
		//取全部用户
		public IEnumerable<User> GetUsers()
		{
			return UserRepository.GetUsers();
		}
	}
}
