using System;
namespace xmuer.Entities.Home
{
    public class CommentVo
    {
		public int ID { get; set; }

		public int StatusID { get; set; }

		public int UserId { get; set; }

		public string Content { get; set; }

		public DateTime Time { get; set; }

		// 供前段显示用
		public string Username { get; set; }
		public string Avatar { get; set; }

		public CommentVo(Comment comment)
        {
			this.ID = comment.ID;
			this.StatusID = comment.StatusID;
			this.UserId = comment.UserId;
			this.Content = comment.Content;
			this.Time = comment.Time;
        }
    }
}
