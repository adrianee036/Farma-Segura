
using System.ComponentModel.DataAnnotations;

namespace Fama_Segura.Core.Domain.Entities
{
    public class Laboratorio
    {
        public int IdLaboratorio { get; set; }
        [MaxLength(40)]
        public string NombreLaboratorio { get; set; } = null!;
        [MaxLength(40)]
        public string Direccion { get; set; } = null!;
        [MaxLength(15)]
        public string Telefono { get; set; } = null!;
        [MaxLength(40)]
        public string Correo { get; set; } = null!;
        [MaxLength(11)]
        public string RNC { get; set; } = null!;
        public DateTime FechaFundacion { get; set; }
        public ICollection<Medicamentos>? Medicamentos { get; set;}

    }
}
