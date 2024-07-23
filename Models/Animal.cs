using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Polimorfismo.Models;
public class Animal
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Genero { get; set; }
    public string Especie { get; set; }
    public double PesoEnKG { get; set; }

    public void Hablar()
    {

    }

    public void Desplazarse()
    {

    }
}