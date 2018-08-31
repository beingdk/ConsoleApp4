namespace ConsoleApp4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mydetail
    {
        public int id { get; set; }

        [StringLength(15)]
        public string name { get; set; }

        [StringLength(15)]
        public string address { get; set; }

        [StringLength(15)]
        public string city { get; set; }

        public long? mobile { get; set; }

        public decimal? salary { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dob { get; set; }
    }
}
