

namespace Fama_Segura.Core.Domain.Entities
{
     public class Medicamentos
    {
        public int IdMedicamento { get; set; }
        public string Nombre { get; set; } = null!;
        public string Código { get; set; } = null!;
        public DateTime FechaVencimiento { get; set; }
        public int IdLaboratorio { get; set; }
        public Laboratorio? Laboratorio { get; set; }
    }
}
