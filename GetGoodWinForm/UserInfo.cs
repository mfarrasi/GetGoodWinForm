namespace GetGoodWinForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInfo")]
    public partial class UserInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int Point { get; set; }

        public bool Dragon { get; set; }

        public bool Cat { get; set; }

        public bool Dog { get; set; }

        public bool Golem { get; set; }

        public bool AnakMiskin { get; set; }
    }
}
