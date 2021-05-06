namespace GetGoodWinForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class compute_node
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(32)]
        public string name { get; set; }

        [Required]
        [StringLength(15)]
        public string address { get; set; }

        [Required]
        [StringLength(30)]
        public string database { get; set; }

        [StringLength(16)]
        public string instance { get; set; }

        public bool active { get; set; }

        public int index { get; set; }

        [Required]
        [StringLength(2)]
        public string driveletter { get; set; }
    }
}
