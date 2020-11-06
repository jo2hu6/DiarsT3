using DiarsT3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsT3.Estrategia
{
    public class RegistradorDeEjercicios
    {
        private IRegisterRoutine registrador;
        private Routine rutina;

        public RegistradorDeEjercicios(Routine rutina)
        {
            this.rutina = rutina;
            if (rutina.Tipo == TipoRutina.AVANZADO)
            {
                registrador = new LevelAvanzado();
            }
            else if (rutina.Tipo == TipoRutina.INTERMEDIO)
            {
                registrador = new NivelIntermedio();
            }
            else
            {
                registrador = new LevelPrincipiante();
            }
        }

        public void RegistrarEjercicios()
        {
            registrador.RegistrarEjercicios(rutina);
        }
    }
}
