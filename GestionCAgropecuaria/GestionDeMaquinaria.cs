using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCAgropecuaria
{
    internal class GestionDeMaquinaria
    {
            static void PrecargaMaquinaria(string[] args)
            {
                
                List<Maquinaria> maquinarias = new List<Maquinaria>
            {
                new Maquinaria("Tractor", 150, "Giuseppe"),
                new Maquinaria("Cosechadora", 300, "Vanessa"),
                new Maquinaria("Arado", 80, "Luisa"),
                new Maquinaria("Regadora", 50, "Antonia"),
                new Maquinaria("Pulverizadora", 200,"Dante")
            };

                
                foreach (var maquinaria in maquinarias)
                {
                    Console.WriteLine(maquinaria);
                }
            }
        }
    }

