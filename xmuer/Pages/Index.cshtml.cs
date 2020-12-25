using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using xmuer.Mapper.Base;
using xmuer.Models.Home;
using xmuer.Entities.Home;

namespace xmuer.Pages
{
    public class IndexModel : PageModel
    {
		protected MyContext Context;

		public List<Share> Shares { get; set; }

		public IndexModel(MyContext context)
		{
			Context = context;
		}

		public void OnGet()
        {
			int size = 10; // todo

			IEnumerable <Entities.Home.Status > statusesIE = Context.Statuses.ToList();
			List<Entities.Home.Status> statuses = new List<Entities.Home.Status>();
			if (statuses.Count() < size)
				statuses = statusesIE.ToList();
			else
				statuses = statusesIE.ToList().GetRange(0, size);

			List<Share> shares = new List<Share>();
			foreach (Entities.Home.Status status in statuses)
			{
				Share share = new Share();
				share.ShareContent = status.Content;
				share.ID = status.ID;
				Entities.Home.User user = Context.Users.SingleOrDefault(s => s.ID == status.UserID);
				share.Username = user.userName;
				share.UserId = user.ID;
				share.Avatar = user.Avatar;
				share.like = status.Like;
				share.commentCount = Context.Comments.Where(s => s.StatusID == status.ID).Count();
				share.Time = status.Time.ToLongTimeString();

				shares.Add(share);
			}

			this.Shares = shares;
		}
    }
}
