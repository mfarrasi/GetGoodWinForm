namespace GetGoodWinForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class configuration_properties
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string key { get; set; }

        [StringLength(4000)]
        public string value { get; set; }

        [Column("default")]
        [StringLength(4000)]
        public string _default { get; set; }

        public short protection { get; set; }

        public short access { get; set; }

        [Required]
        [StringLength(50)]
        public string datatype { get; set; }
    }
}
