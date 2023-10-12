using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOTNET_Core_Project.Models
{
    public class Pets
    {
        [Key]
        public int PetNo { get; set; }
        public string PetAdi { get; set; }
        public string PetHastalik { get; set; }
        public string PetYas { get; set; }
        [ForeignKey("turler")]
        public int TurNo { get; set; }
        public virtual Turler turler { get; set; }
    }
}
