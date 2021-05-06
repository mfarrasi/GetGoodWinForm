namespace GetGoodWinForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class version_history
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int version { get; set; }

        public DateTime date_installed { get; set; }
    }
}
