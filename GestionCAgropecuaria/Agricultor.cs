using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCAgropecuaria
{

        public class Agricultor
        {
            public string NombreAg { get; set; }
            public double Hectareas { get; set; }

            public Agricultor(string nombre, double hectareas)
            {
                NombreAg = nombre;
                Hectareas = hectareas;
            }

            public override string ToString()
            {
                return $"{NombreAg} trabaja {Hectareas} hectáreas.";
            }
        }
    }
