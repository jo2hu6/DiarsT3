using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsT3.Models
{
    public class ExerciseRoutine
    {
        public int Id { get; set; }
        public int RutinaId { get; set; }
        public int EjercicioId { get; set; }
        public int Duracion { get; set; }
        public Routine Rutina { get; set; }
        public Exercise Ejercicio { get; set; }
    }
}
