using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GetGoodWinForm
{
    public partial class PointsEDM : DbContext
    {
        public PointsEDM()
            : base("name=Model1")
        {
        }

        public virtual DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
