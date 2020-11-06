using DiarsT3.DB.Context;
using DiarsT3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsT3.Estrategia
{
    public class LevelPrincipiante : IRegisterRoutine
    {
        private readonly DiarsT3Context context;

        public LevelPrincipiante()
        {
            context = new DiarsT3Context();
        }

        public void RegistrarEjercicios(Routine rutina)
        {
            var ejercicios = context.Ejercicios.ToList();
            var rand = new Random();
            for (var i = 0; i < 5; i++)
            {
                var ejercicioRutina = new ExerciseRoutine();
                ejercicioRutina.RutinaId = rutina.Id;
                var index = rand.Next(ejercicios.Count);
                ejercicioRutina.EjercicioId = ejercicios[index].Id;
                ejercicioRutina.Duracion = rand.Next(60, 121);
                context.EjercicioRutinas.Add(ejercicioRutina);
                context.SaveChanges();
            }
        }
    }
}
