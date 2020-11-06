using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsT3.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string LinkYoutube { get; set; }
        public List<ExerciseRoutine> EjercicioRutinas { get; set; }
    }
}
