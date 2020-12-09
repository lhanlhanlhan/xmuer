using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xmuer.Entities.Home;
using xmuer.Models.Home;
using xmuer.Service.Interface;
using Microsoft.AspNetCore.Http;

namespace xmuer.Controllers
{
	[Route("home/[controller]")]
	[ApiController]
	public class UserController : Controller
	{
		#region 属性声明

		protected IUserService UserService;
		#endregion

		#region 构造函数

		public UserController(IUserService userService)
		{
			UserService = userService;
		}

		#endregion

		[HttpGet]
		public IActionResult GetUsers()
		{
			UserListModel userListModel = new UserListModel();

			IEnumerable<User> userIE = UserService.GetUsers();
			if (userIE != null)
			{
				userListModel.users.AddRange(userIE);
			}

			return View("Pages/User/UserList.cshtml", userListModel);
		}

		[HttpGet("name")]
		public IActionResult GetUsersByName(string name)
		{
			UserListModel userListModel = new UserListModel();

			IEnumerable<User> userIE = UserService.GetUserByName(name);
			if (userIE != null)
			{
				userListModel.users.AddRange(userIE);
			}

			return View("Pages/User/UserList.cshtml", userListModel);
		}

		[HttpGet("colledge")]
		public IActionResult GetUsersByColledge(string colledge)
		{
			UserListModel userListModel = new UserListModel();

			IEnumerable<User> userIE = UserService.GetUserByColledge(colledge);
			if (userIE != null)
			{
				userListModel.users.AddRange(userIE);
			}

			return View("Pages/User/UserList.cshtml", userListModel);
		}

		[HttpGet("department")]
		public IActionResult GetUsersByDepartment(string department)
		{
			UserListModel userListModel = new UserListModel();

			IEnumerable<User> userIE = UserService.GetUserByDepartment(department);
			if (userIE != null)
			{
				userListModel.users.AddRange(userIE);
			}

			return View("Pages/User/UserList.cshtml", userListModel);
		}

		[HttpGet("major")]
		public IActionResult GetUsersByMajor(string major)
		{
			UserListModel userListModel = new UserListModel();

			IEnumerable<User> userIE = UserService.GetUserByMajor(major);
			if (userIE != null)
			{
				userListModel.users.AddRange(userIE);
			}

			return View("Pages/User/UserList.cshtml", userListModel);
		}

		[HttpGet("studentNo")]
		public IActionResult GetUsersByStudentNo(string studentNo)
		{
			UserListModel userListModel = new UserListModel();

			IEnumerable<User> userIE = UserService.GetUserByStudentNo(studentNo);
			if (userIE != null)
			{
				userListModel.users.AddRange(userIE);
			}

			return View("Pages/User/UserList.cshtml", userListModel);
		}


	}
}
