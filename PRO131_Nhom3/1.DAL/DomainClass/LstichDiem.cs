using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("LSTichDiem")]
    public partial class LstichDiem
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? IdTichDiem { get; set; }
        [Column("IdCTTinhDiem")]
        public Guid? IdCttinhDiem { get; set; }
        public int? HeSoTich { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdCttinhDiem))]
        [InverseProperty(nameof(CttichDiem.LstichDiems))]
        public virtual CttichDiem IdCttinhDiemNavigation { get; set; }
        [ForeignKey(nameof(IdTichDiem))]
        [InverseProperty(nameof(TichDiem.LstichDiems))]
        public virtual TichDiem IdTichDiemNavigation { get; set; }
    }
}
