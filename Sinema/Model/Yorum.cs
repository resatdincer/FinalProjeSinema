namespace Sinema.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yorum")]
    public partial class Yorum
    {
        public int YorumID { get; set; }

        public string YorumIcerik { get; set; }

        public Guid? UserId { get; set; }

        public int FilmID { get; set; }

        public virtual Film Film { get; set; }
    }
}
