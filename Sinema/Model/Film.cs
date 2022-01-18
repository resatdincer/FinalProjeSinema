namespace Sinema.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Film")]
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            Yorum = new HashSet<Yorum>();
            Oyuncu = new HashSet<Oyuncu>();
        }

        public int FilmID { get; set; }

        [Required]
        [StringLength(100)]
        public string FilmAdi { get; set; }

        public int? FilmKategoriId { get; set; }

        public int? YonetmenId { get; set; }

        public virtual FilmDetay FilmDetay { get; set; }

        public virtual FilmKategori FilmKategori { get; set; }

        public virtual Yonetmen Yonetmen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorum> Yorum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oyuncu> Oyuncu { get; set; }
    }
}
