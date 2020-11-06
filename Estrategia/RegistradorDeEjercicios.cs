using DiarsT3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsT3.Estrategia
{
    public class RegistradorDeEjercicios
    {
        private IRegistrarRutina registrador;
        private Rutina rutina;

        public RegistradorDeEjercicios(Rutina rutina)
        {
            this.rutina = rutina;
            if (rutina.Tipo == TipoRutina.AVANZADO)
            {
                registrador = new NivelAvanzado();
            }
            else if (rutina.Tipo == TipoRutina.INTERMEDIO)
            {
                registrador = new NivelIntermedio();
            }
            else
            {
                registrador = new NivelPrincipiante();
            }
        }

        public void RegistrarEjercicios()
        {
            registrador.RegistrarEjercicios(rutina);
        }
    }
}
