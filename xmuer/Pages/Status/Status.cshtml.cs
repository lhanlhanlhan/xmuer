using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using xmuer.Entities.Home;
using xmuer.Mapper.Base;

namespace xmuer.Pages.Status
{
    public class StatusModel : PageModel
    {
        protected MyContext Context;
        public StatusModel(MyContext context)
        {
            Context = context;
        }

        public string Username { get; set; }
        public Entities.Home.Share Share { get; set; }
        public List<CommentVo> Comments { get; set; }

        public IActionResult OnGet(int shareId)
        {
            // 获取 share
            Entities.Home.Status status = Context.Statuses.Find(shareId);
            if (status == null)
            {
                return Redirect("/");
            }
            Share = new Entities.Home.Share();
            Share.ShareContent = status.Content;
            Share.ID = status.ID;
            Entities.Home.User user = Context.Users.SingleOrDefault(s => s.ID == status.UserID);
            Share.Username = user.userName;
            Share.UserId = user.ID;
            Share.Avatar = user.Avatar;
            Share.like = status.Like;
            Share.commentCount = Context.Comments.Where(s => s.StatusID == status.ID).Count();
            Share.Time = status.Time.ToString();

            // 获取评论
            IQueryable<Comment> commentsQuery = from c in Context.Comments
                                                where c.StatusID == Share.ID
                                                select c;

            Comments = new List<CommentVo>();
            foreach (var comment in commentsQuery)
            {
                // 获取评论源头用户资讯
                Entities.Home.User commentByUser = Context.Users.Find(comment.UserId);
                if (commentByUser == null)
                {
                    continue;
                }
                CommentVo vo = new CommentVo(comment);
                vo.Username = commentByUser.userName;
                vo.Avatar = commentByUser.Avatar;
                Comments.Add(vo);
            }

            return Page();
        }
    }
}
