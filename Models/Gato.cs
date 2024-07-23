using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Polimorfismo.Models;
public class Gato : Animal
{
    public override void Hablar()
    {
        base.Hablar(); // Llama al método de la clase base
        Console.WriteLine("El gato dice meow!");
    }

    public override void Desplazarse()
    {
        base.Desplazarse();
        Console.WriteLine("El gato se desplaza saltando");
    }
}