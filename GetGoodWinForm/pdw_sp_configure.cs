namespace GetGoodWinForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pdw_sp_configure
    {
        [Key]
        [StringLength(35)]
        public string name { get; set; }

        public int? minimum { get; set; }

        public int? maximum { get; set; }

        public int? config_value { get; set; }

        public int? run_value { get; set; }
    }
}
