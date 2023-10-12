using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOTNET_Core_Project.Models
{
    public class Veterinerler
    {
        [Key]
        public int VeterinerNo { get; set; }
        public string VeterinerAdi { get; set; }
        public decimal Maas { get; set; }
        public string VeterinerTelefon { get; set; }

        [ForeignKey("hastaneler")]
        public int HastaneNo { get; set; }
        public virtual Hastaneler hastaneler { get; set; }
    }
}
