using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GetGoodWinForm
{
    public partial class UserEDM : DbContext
    {
        public UserEDM()
            : base("name=UserEDM")
        {
        }

        public virtual DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
