﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("CTTichDiem")]
    public partial class CttichDiem
    {
        public CttichDiem()
        {
            LstichDiems = new HashSet<LstichDiem>();
        }

        [Key]
        public Guid Id { get; set; }
        public Guid? IdHoaDon { get; set; }
        public int? HeSoTich { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdHoaDon))]
        [InverseProperty(nameof(HoaDon.CttichDiems))]
        public virtual HoaDon IdHoaDonNavigation { get; set; }
        [InverseProperty(nameof(LstichDiem.IdCttinhDiemNavigation))]
        public virtual ICollection<LstichDiem> LstichDiems { get; set; }
    }
}
