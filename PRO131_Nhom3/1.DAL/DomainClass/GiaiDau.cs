using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("GiaiDau")]
    [Index(nameof(Ma), Name = "UQ__GiaiDau__3214CC9E769398F5", IsUnique = true)]
    public partial class GiaiDau
    {
        public GiaiDau()
        {
            ChiTietSps = new HashSet<ChiTietSp>();
            Teams = new HashSet<Team>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietSp.IdGiaiDauNavigation))]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
        [InverseProperty(nameof(Team.IdGdNavigation))]
        public virtual ICollection<Team> Teams { get; set; }
    }
}
