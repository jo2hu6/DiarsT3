using DiarsT3.DB.Context;
using DiarsT3.Models;
using System;
using System.Linq;

namespace DiarsT3.Estrategia
{
    public class NivelAvanzado : IRegistrarRutina
    {
        private readonly DiarsT3Context context;

        public NivelAvanzado()
        {
            context = new DiarsT3Context();
        }

        public void RegistrarEjercicios(Rutina rutina)
        {
            var ejercicios = context.Ejercicios.ToList();
            var rand = new Random();
            for (var i = 0; i < 15; i++)
            {
                var ejercicioRutina = new EjercicioRutina();
                ejercicioRutina.RutinaId = rutina.Id;
                var index = rand.Next(ejercicios.Count);
                ejercicioRutina.EjercicioId = ejercicios[index].Id;
                ejercicioRutina.Duracion = 120;
                context.EjercicioRutinas.Add(ejercicioRutina);
                context.SaveChanges();
            }
        }
    }
}
