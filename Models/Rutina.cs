using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsT3.Models
{
    public class TipoRutina
    {
        public const string PRINCIPIANTE = "Principiante";
        public const string INTERMEDIO = "Intermedio";
        public const string AVANZADO = "Avanzado";
    }

    public class Rutina
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public Usuario Usuario { get; set; }
        public List<EjercicioRutina> EjercicioRutinas { get; set; }

        public int CalcularDuracion()
        {
            var acumulado = 0;
            foreach (var ejercicio in EjercicioRutinas)
            {
                acumulado += ejercicio.Duracion;
            }
            return acumulado;
        }
    }
}
