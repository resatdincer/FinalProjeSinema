namespace Sinema.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FilmKategori")]
    public partial class FilmKategori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FilmKategori()
        {
            Film = new HashSet<Film>();
        }
        [ScaffoldColumn(false)]
        public int FilmKategoriId { get; set; }

        [Required]
        [StringLength(100)]
        public string FilmKategoriAdi { get; set; }

        [StringLength(250)]
        public string KategoriAciklama { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Film> Film { get; set; }
    }
}
