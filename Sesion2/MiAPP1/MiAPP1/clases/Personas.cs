﻿using MiAPP1.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAPP1.clases
{
    internal class Personas
    {
        public Personas() { }
        public string Nombre { get; set; }
        public DateTime FechaNac { get; set; }

        public int CalcularEdad()
        {
            return DateTime.Now.Year - FechaNac.Year;
        }
        public string EvaluarEdad()
        {
            if (CalcularEdad() >= 18) return "Mayor de edad";
            return "Menor de edad";
        }





    }

}
