﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Consola1
{
    class Restar:Operaciones
    {
        public void Iniciar()
        {
            Init("Vamos a restar dos números");
            Resultado = operacion(NumeroUno, NumeroDos);
            darSalida(Resultado);
        }

        static float operacion(float a, float b)
        {

            return a - b;
        }
    }
}
