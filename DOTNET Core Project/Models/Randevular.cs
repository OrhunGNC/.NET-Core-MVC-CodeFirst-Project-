using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOTNET_Core_Project.Models
{
    public class Randevular
    {
        [Key]
        public int RandevuNo { get; set; }
        public string RandevuSaati { get; set; }
        public DateTime RandevuTarihi { get; set; }
        [ForeignKey("musteriler")]
        public int MusteriNo { get; set; }

        public virtual Musteriler musteriler { get; set; }
        [ForeignKey("veterinerler")]
        public int VeterinerNo { get; set; }

        public virtual Veterinerler veterinerler { get; set; }

    }
}
