namespace Sinema.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Oyuncu")]
    public partial class Oyuncu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Oyuncu()
        {
            Film = new HashSet<Film>();
        }

        public int OyuncuID { get; set; }

        [Required]
        [StringLength(100)]
        public string OyuncuAdi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OyuncuDogum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Film> Film { get; set; }
    }
}
