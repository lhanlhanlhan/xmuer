using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace xmuer.Entities.Home
{
    [Table("user_info")]
    public class UserInfo
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }

        [Column("user_name")]
        public String userName { get; set; }

        [Column("real_name")]
        public String realName { get; set; }

        [Column("gender")]
        public int gender { get; set; }

        [Column("birthday")]
        public DateTime birthday { get; set; }

        [Column("hometown")]
        public String hometown { get; set; }

        [Column("email")]
        public String email { get; set; }

        [Column("mobile")]
        public String mobile { get; set; }

        [Column("university")]
        public String university { get; set; }

        [Column("high_school")]
        public String highSchool { get; set; }

        [Column("junior_high_school")]
        public String juniorHighSchool { get; set; }

        [Column("primary_school")]
        public String primarySchool { get; set; }

        [Column("hobby_music")]
        public String hobbyMusic { get; set; }

        [Column("hobby_book")]
        public String hobbyBook { get; set; }

        [Column("hobby_movie")]
        public String hobbyMovie { get; set; }

        [Column("hobby_game")]
        public String hobbyGame { get; set; }

        [Column("hobby_anime")]
        public String hobbyAnime { get; set; }

        [Column("hobby_sport")]
        public String hobbySport { get; set; }

        [Column("hobby_other")]
        public String hobbyOther { get; set; }

    }
}
