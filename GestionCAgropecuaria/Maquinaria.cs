using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCAgropecuaria
{


    public class Maquinaria
    {
        public string NombreMaq { get; set; } //tipo de maquina
        public int Costo { get; set; } //costo por hora
        public string Propietario { get; set; }
        public List<Maquinaria> maquinarias { get; set; } //lista para llenar



        public Maquinaria(string nombre, int Costo, string Propietario)
        {
            NombreMaq = nombre;
            this.Costo = Costo;
            this.Propietario = Propietario;
            maquinarias = new List<Maquinaria>();
        }

        public string ToString()
        {
            return $"{NombreMaq} cuesta {Costo} es propiedad de {Propietario}";
        }


        public void AgregarHabitacion(Maquinaria maquinaria)
        {
           maquinaria.Add(maquinarias); //que falta?
        }

        public void ListarMaquinaria()
        {
            foreach (var Maquinarias  in maquinarias)
            {
                Console.WriteLine(maquinarias);
            }
        }
    }
}




