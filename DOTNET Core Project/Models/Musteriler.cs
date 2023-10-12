using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOTNET_Core_Project.Models
{
    public class Musteriler
    {
        [Key]
        public int MusteriNo { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriTelefon { get; set; }
        public string MusteriAdres { get; set; }
        [ForeignKey("pets")]
        public int PetNo { get; set; }
        public virtual Pets pets { get; set; }
    }
}
