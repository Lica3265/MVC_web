namespace Mymagicwilltearyouapart.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [Key]
        [StringLength(10)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserPassword { get; set; }
    }
}
