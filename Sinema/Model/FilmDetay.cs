namespace Sinema.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FilmDetay")]
    public partial class FilmDetay
    {
        [Key]
        public int FilmID { get; set; }

        public string Aciklama { get; set; }

        [Column(TypeName = "date")]
        public DateTime YapimYili { get; set; }

        public decimal? YapimButcesi { get; set; }

        public virtual Film Film { get; set; }
    }
}
