namespace GetGoodWinForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("filegroup")]
    public partial class filegroup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        public int? distribution_id { get; set; }

        [Required]
        [StringLength(10)]
        public string min_filesize { get; set; }

        [Required]
        [StringLength(10)]
        public string max_filesize { get; set; }

        [Required]
        [StringLength(10)]
        public string default_filegrowth { get; set; }

        public int type { get; set; }

        public bool is_shell { get; set; }
    }
}
