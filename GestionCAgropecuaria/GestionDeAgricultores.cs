using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCAgropecuaria;

internal class GestionDeAgricultores
{
    static void PrecargaAgricultores(string[] args)
    {
        
        List<Agricultor> agricultores = new List<Agricultor>
            {
                new Agricultor("Juan Pérez", 150.5),
                new Agricultor("María González", 200.0),
                new Agricultor("Carlos Rodríguez", 120.3),
                new Agricultor("Ana López", 80.0),
                new Agricultor("Pedro Martínez", 50.5)
            };

        
        foreach (var agricultor in agricultores)
        {
            Console.WriteLine(agricultor);
        }
    }
}
