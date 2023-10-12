using System.ComponentModel.DataAnnotations;

namespace DOTNET_Core_Project.Models
{
    public class Hastaneler
    {
        [Key]
        public int HastaneNo { get; set; }
        public string HastaneAdres { get; set; }
        public string HastaneTelefon { get; set; }
        public string CalisanSayisi { get; set; }
        public string SorumluKisi { get; set; }
    }
}
