using System.ComponentModel.DataAnnotations;

namespace DOTNET_Core_Project.Models
{
    public class Turler
    {
        [Key]
        public int TurNo { get; set; }
        public string TurAdi { get; set; }
        public int TurSayisi { get; set; }
    }
}
