using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xmuer.Entities.Home;
using xmuer.Models.Home;
using xmuer.Service.Interface;
using Microsoft.AspNetCore.Http;
using xmuer.Mapper.Base;
using DiscussClassSystem.Common.Infrastructure;
using xmuer.Common.Infrastructure;

namespace xmuer.Controllers
{
	[Route("home/[controller]")]
	[ApiController]
	public class UserController : Controller
	{
		#region 属性声明

		protected IUserService UserService;
		protected MyContext Context;
		#endregion

		#region 构造函数

		public UserController(IUserService userService, MyContext context)
		{
			UserService = userService;
			Context = context;
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
		public IActionResult GetUsersByName([FromForm] string name)
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
		public IActionResult GetUsersByColledge([FromForm] string colledge)
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
		public IActionResult GetUsersByDepartment([FromForm] string department)
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
		public IActionResult GetUsersByMajor([FromForm] string major)
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
		public IActionResult GetUsersByStudentNo([FromForm] string studentNo)
		{
			UserListModel userListModel = new UserListModel();

			IEnumerable<User> userIE = UserService.GetUserByStudentNo(studentNo);
			if (userIE != null)
			{
				userListModel.users.AddRange(userIE);
			}

			return View("Pages/User/UserList.cshtml", userListModel);
		}

		[HttpPost("like/{id}")]
		public Message LikeOther(int id)
		{
			var status = Context.Statuses.SingleOrDefault(s=>s.ID == id);
			var update = false;

			if (status != null)
			{
				status.like++;
				update = Context.SaveChanges() > 0;
			}
			if (update)
				return new Message((int)MessageCode.OK, MessageCode.OK.GetDescription());
			return new Message((int)MessageCode.INTERNAL_SERVER_ERR, 
					MessageCode.INTERNAL_SERVER_ERR.GetDescription());
		}

		[HttpPost("comment/{id}")]
		public Message CommentOther(int id, [FromForm] string content)
		{
			Comment comment = new Comment();
			comment.StatusID = id;
			comment.Content = content;
			Context.Comments.Add(comment);
			var saveState = Context.SaveChanges() > 0;
			if (saveState)
				return new Message((int)MessageCode.OK, MessageCode.OK.GetDescription());
			return new Message((int)MessageCode.INTERNAL_SERVER_ERR,
					MessageCode.INTERNAL_SERVER_ERR.GetDescription());
		}
	}
}
