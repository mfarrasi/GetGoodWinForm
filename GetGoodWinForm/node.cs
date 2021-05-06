namespace GetGoodWinForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("node")]
    public partial class node
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public short type { get; set; }

        [Required]
        [StringLength(32)]
        public string name { get; set; }

        [Required]
        [StringLength(15)]
        public string address { get; set; }

        public bool active { get; set; }
    }
}
