using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("Size")]
    [Index(nameof(Ma), Name = "UQ__Size__3214CC9E4868D58D", IsUnique = true)]
    public partial class Size
    {
        public Size()
        {
            ChiTietSps = new HashSet<ChiTietSp>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [Column("Size")]
        [StringLength(30)]
        public string Size1 { get; set; }
        [Column("CM", TypeName = "decimal(18, 0)")]
        public decimal? Cm { get; set; }
        [Column("INCH", TypeName = "decimal(18, 0)")]
        public decimal? Inch { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietSp.IdSizeNavigation))]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}
